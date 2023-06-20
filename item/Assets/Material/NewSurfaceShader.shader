Shader "Snoopy/AlphaRimPro"
{
	Properties
	{
		_MainTex("Particle Texture", 2D) = "white" {}
		_RimColor("Rim Color", Color) = (0.5,0.5,0.5,0.5)
		_InnerColor("Inner Color", Color) = (0.5,0.5,0.5,0.5)
		_InnerColorPower("Inner Color Power", Range(0.0,1.0)) = 0.5
		_RimPower("Rim Power", Range(0.0,5.0)) = 2.5
		_AlphaPower("Alpha Rim Power", Range(0.0,8.0)) = 4.0
		_AllPower("All Power", Range(0.0, 10.0)) = 1.0
		_InnerAlphaBase("Inner Alpha Base", Range(0.0, 1.0)) = 1.0
	}
		SubShader
		{
			Tags{ "Queue" = "Transparent" "IgnoreProjector" = "True" "RenderType" = "Transparent" }

			Pass
			{
				// 开启深度写入
				ZWrite On
				// 设置颜色通道的写掩码，0为不写入任何颜色
				ColorMask 0
			}

			CGPROGRAM
			#pragma surface surf Lambert alpha

			struct Input
			{
				float3 viewDir;
				float2 uv_MainTex;
				INTERNAL_DATA
			};

			sampler2D _MainTex;
			float4 _RimColor;
			float _RimPower;
			float _AlphaPower;
			float _AlphaMin;
			float _InnerColorPower;
			float _AllPower;
			float4 _InnerColor;
			float _InnerAlphaBase;

			void surf(Input IN, inout SurfaceOutput o)
			{
				float4 col = tex2D(_MainTex, IN.uv_MainTex);
				o.Albedo = col.rgb;
				half rim = 1.0 - saturate(dot(normalize(IN.viewDir), o.Normal));
				o.Emission = _RimColor.rgb * pow(rim, _RimPower) * _AllPower + (_InnerColor.rgb * 2 * _InnerColorPower);
				o.Alpha = (_InnerAlphaBase + (pow(rim, _AlphaPower)) * _AllPower) * col.a;
			}
			ENDCG
		}
			Fallback "VertexLit"
}