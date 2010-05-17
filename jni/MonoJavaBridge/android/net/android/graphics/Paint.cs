namespace android.graphics 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Paint : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Paint() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.Paint), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.graphics.Paint(@__env); 
			} 
		} 
		protected Paint(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class Align : java.lang.Enum
		{ 
			internal new static global::java.lang.Class staticClass; 
			static Align() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.Paint.Align), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.graphics.Paint.Align(@__env); 
				} 
			} 
			internal Align(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _valueOf2835; 
			public static android.graphics.Paint.Align valueOf(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Paint.Align>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Paint.Align.staticClass, _valueOf2835, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _values2836; 
			public static android.graphics.Paint.Align[] values() 
			{ 
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Paint.Align.staticClass, _values2836)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CENTER2837; 
			public static android.graphics.Paint.Align CENTER
			{ 
				get 
				{ 
					return default(android.graphics.Paint.Align); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _LEFT2838; 
			public static android.graphics.Paint.Align LEFT
			{ 
				get 
				{ 
					return default(android.graphics.Paint.Align); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _RIGHT2839; 
			public static android.graphics.Paint.Align RIGHT
			{ 
				get 
				{ 
					return default(android.graphics.Paint.Align); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.graphics.Paint.Align.staticClass = @__class; 
				global::android.graphics.Paint.Align._valueOf2835 = @__env.GetStaticMethodID(global::android.graphics.Paint.Align.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Paint$Align;"); 
				global::android.graphics.Paint.Align._values2836 = @__env.GetStaticMethodID(global::android.graphics.Paint.Align.staticClass, "values", "()[Landroid/graphics/Paint/Align;"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class Cap : java.lang.Enum
		{ 
			internal new static global::java.lang.Class staticClass; 
			static Cap() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.Paint.Cap), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.graphics.Paint.Cap(@__env); 
				} 
			} 
			internal Cap(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _valueOf2840; 
			public static android.graphics.Paint.Cap valueOf(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Paint.Cap>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Paint.Cap.staticClass, _valueOf2840, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _values2841; 
			public static android.graphics.Paint.Cap[] values() 
			{ 
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Paint.Cap.staticClass, _values2841)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _BUTT2842; 
			public static android.graphics.Paint.Cap BUTT
			{ 
				get 
				{ 
					return default(android.graphics.Paint.Cap); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _ROUND2843; 
			public static android.graphics.Paint.Cap ROUND
			{ 
				get 
				{ 
					return default(android.graphics.Paint.Cap); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _SQUARE2844; 
			public static android.graphics.Paint.Cap SQUARE
			{ 
				get 
				{ 
					return default(android.graphics.Paint.Cap); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.graphics.Paint.Cap.staticClass = @__class; 
				global::android.graphics.Paint.Cap._valueOf2840 = @__env.GetStaticMethodID(global::android.graphics.Paint.Cap.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Paint$Cap;"); 
				global::android.graphics.Paint.Cap._values2841 = @__env.GetStaticMethodID(global::android.graphics.Paint.Cap.staticClass, "values", "()[Landroid/graphics/Paint/Cap;"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class FontMetrics : java.lang.Object
		{ 
			internal static global::java.lang.Class staticClass; 
			static FontMetrics() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.Paint.FontMetrics), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.graphics.Paint.FontMetrics(@__env); 
				} 
			} 
			protected FontMetrics(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _FontMetrics2845; 
			public FontMetrics()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.graphics.Paint.FontMetrics.staticClass, _FontMetrics2845, this); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _top2846; 
			public float top
			{ 
				get 
				{ 
					return default(float); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _ascent2847; 
			public float ascent
			{ 
				get 
				{ 
					return default(float); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _descent2848; 
			public float descent
			{ 
				get 
				{ 
					return default(float); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _bottom2849; 
			public float bottom
			{ 
				get 
				{ 
					return default(float); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _leading2850; 
			public float leading
			{ 
				get 
				{ 
					return default(float); 
				} 
				set 
				{ 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.graphics.Paint.FontMetrics.staticClass = @__class; 
				global::android.graphics.Paint.FontMetrics._FontMetrics2845 = @__env.GetMethodID(global::android.graphics.Paint.FontMetrics.staticClass, "<init>", "()V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class FontMetricsInt : java.lang.Object
		{ 
			internal static global::java.lang.Class staticClass; 
			static FontMetricsInt() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.Paint.FontMetricsInt), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.graphics.Paint.FontMetricsInt(@__env); 
				} 
			} 
			protected FontMetricsInt(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _toString2851; 
			public override java.lang.String toString() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.graphics.Paint.FontMetricsInt)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString2851)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.Paint.FontMetricsInt.staticClass, _toString2851)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _FontMetricsInt2852; 
			public FontMetricsInt()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.graphics.Paint.FontMetricsInt.staticClass, _FontMetricsInt2852, this); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _top2853; 
			public int top
			{ 
				get 
				{ 
					return default(int); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _ascent2854; 
			public int ascent
			{ 
				get 
				{ 
					return default(int); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _descent2855; 
			public int descent
			{ 
				get 
				{ 
					return default(int); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _bottom2856; 
			public int bottom
			{ 
				get 
				{ 
					return default(int); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _leading2857; 
			public int leading
			{ 
				get 
				{ 
					return default(int); 
				} 
				set 
				{ 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.graphics.Paint.FontMetricsInt.staticClass = @__class; 
				global::android.graphics.Paint.FontMetricsInt._toString2851 = @__env.GetMethodID(global::android.graphics.Paint.FontMetricsInt.staticClass, "toString", "()Ljava/lang/String;"); 
				global::android.graphics.Paint.FontMetricsInt._FontMetricsInt2852 = @__env.GetMethodID(global::android.graphics.Paint.FontMetricsInt.staticClass, "<init>", "()V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class Join : java.lang.Enum
		{ 
			internal new static global::java.lang.Class staticClass; 
			static Join() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.Paint.Join), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.graphics.Paint.Join(@__env); 
				} 
			} 
			internal Join(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _valueOf2858; 
			public static android.graphics.Paint.Join valueOf(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Paint.Join>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Paint.Join.staticClass, _valueOf2858, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _values2859; 
			public static android.graphics.Paint.Join[] values() 
			{ 
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Paint.Join.staticClass, _values2859)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _BEVEL2860; 
			public static android.graphics.Paint.Join BEVEL
			{ 
				get 
				{ 
					return default(android.graphics.Paint.Join); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _MITER2861; 
			public static android.graphics.Paint.Join MITER
			{ 
				get 
				{ 
					return default(android.graphics.Paint.Join); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _ROUND2862; 
			public static android.graphics.Paint.Join ROUND
			{ 
				get 
				{ 
					return default(android.graphics.Paint.Join); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.graphics.Paint.Join.staticClass = @__class; 
				global::android.graphics.Paint.Join._valueOf2858 = @__env.GetStaticMethodID(global::android.graphics.Paint.Join.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Paint$Join;"); 
				global::android.graphics.Paint.Join._values2859 = @__env.GetStaticMethodID(global::android.graphics.Paint.Join.staticClass, "values", "()[Landroid/graphics/Paint/Join;"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class Style : java.lang.Enum
		{ 
			internal new static global::java.lang.Class staticClass; 
			static Style() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.Paint.Style), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.graphics.Paint.Style(@__env); 
				} 
			} 
			internal Style(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _valueOf2863; 
			public static android.graphics.Paint.Style valueOf(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Paint.Style>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Paint.Style.staticClass, _valueOf2863, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _values2864; 
			public static android.graphics.Paint.Style[] values() 
			{ 
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Paint.Style.staticClass, _values2864)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _FILL2865; 
			public static android.graphics.Paint.Style FILL
			{ 
				get 
				{ 
					return default(android.graphics.Paint.Style); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _FILL_AND_STROKE2866; 
			public static android.graphics.Paint.Style FILL_AND_STROKE
			{ 
				get 
				{ 
					return default(android.graphics.Paint.Style); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _STROKE2867; 
			public static android.graphics.Paint.Style STROKE
			{ 
				get 
				{ 
					return default(android.graphics.Paint.Style); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.graphics.Paint.Style.staticClass = @__class; 
				global::android.graphics.Paint.Style._valueOf2863 = @__env.GetStaticMethodID(global::android.graphics.Paint.Style.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Paint$Style;"); 
				global::android.graphics.Paint.Style._values2864 = @__env.GetStaticMethodID(global::android.graphics.Paint.Style.staticClass, "values", "()[Landroid/graphics/Paint/Style;"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _set2868; 
		public virtual void set(android.graphics.Paint arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				@__env.CallVoidMethod(this, _set2868, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Paint.staticClass, _set2868, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _reset2869; 
		public virtual void reset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				@__env.CallVoidMethod(this, _reset2869); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Paint.staticClass, _reset2869); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFlags2870; 
		public virtual int getFlags() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return @__env.CallIntMethod(this, _getFlags2870); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.Paint.staticClass, _getFlags2870); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFlags2871; 
		public virtual void setFlags(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				@__env.CallVoidMethod(this, _setFlags2871, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Paint.staticClass, _setFlags2871, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getColor2872; 
		public virtual int getColor() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return @__env.CallIntMethod(this, _getColor2872); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.Paint.staticClass, _getColor2872); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDither2873; 
		public virtual void setDither(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				@__env.CallVoidMethod(this, _setDither2873, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Paint.staticClass, _setDither2873, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFilterBitmap2874; 
		public virtual void setFilterBitmap(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				@__env.CallVoidMethod(this, _setFilterBitmap2874, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Paint.staticClass, _setFilterBitmap2874, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAlpha2875; 
		public virtual void setAlpha(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				@__env.CallVoidMethod(this, _setAlpha2875, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Paint.staticClass, _setAlpha2875, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setColorFilter2876; 
		public virtual android.graphics.ColorFilter setColorFilter(android.graphics.ColorFilter arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.ColorFilter>(@__env, @__env.CallObjectMethodPtr(this, _setColorFilter2876, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.ColorFilter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.Paint.staticClass, _setColorFilter2876, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTypeface2877; 
		public virtual android.graphics.Typeface setTypeface(android.graphics.Typeface arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Typeface>(@__env, @__env.CallObjectMethodPtr(this, _setTypeface2877, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Typeface>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.Paint.staticClass, _setTypeface2877, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTextSize2878; 
		public virtual float getTextSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return @__env.CallFloatMethod(this, _getTextSize2878); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.graphics.Paint.staticClass, _getTextSize2878); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTextSize2879; 
		public virtual void setTextSize(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				@__env.CallVoidMethod(this, _setTextSize2879, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Paint.staticClass, _setTextSize2879, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTextScaleX2880; 
		public virtual float getTextScaleX() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return @__env.CallFloatMethod(this, _getTextScaleX2880); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.graphics.Paint.staticClass, _getTextScaleX2880); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTextScaleX2881; 
		public virtual void setTextScaleX(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				@__env.CallVoidMethod(this, _setTextScaleX2881, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Paint.staticClass, _setTextScaleX2881, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTypeface2882; 
		public virtual android.graphics.Typeface getTypeface() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Typeface>(@__env, @__env.CallObjectMethodPtr(this, _getTypeface2882)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Typeface>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.Paint.staticClass, _getTypeface2882)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setShadowLayer2883; 
		public virtual void setShadowLayer(float arg0, float arg1, float arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				@__env.CallVoidMethod(this, _setShadowLayer2883, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Paint.staticClass, _setShadowLayer2883, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAlpha2884; 
		public virtual int getAlpha() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return @__env.CallIntMethod(this, _getAlpha2884); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.Paint.staticClass, _getAlpha2884); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isAntiAlias2885; 
		public virtual bool isAntiAlias() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return @__env.CallBooleanMethod(this, _isAntiAlias2885); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Paint.staticClass, _isAntiAlias2885); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAntiAlias2886; 
		public virtual void setAntiAlias(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				@__env.CallVoidMethod(this, _setAntiAlias2886, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Paint.staticClass, _setAntiAlias2886, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isDither2887; 
		public virtual bool isDither() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return @__env.CallBooleanMethod(this, _isDither2887); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Paint.staticClass, _isDither2887); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isLinearText2888; 
		public virtual bool isLinearText() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return @__env.CallBooleanMethod(this, _isLinearText2888); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Paint.staticClass, _isLinearText2888); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setLinearText2889; 
		public virtual void setLinearText(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				@__env.CallVoidMethod(this, _setLinearText2889, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Paint.staticClass, _setLinearText2889, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isSubpixelText2890; 
		public virtual bool isSubpixelText() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return @__env.CallBooleanMethod(this, _isSubpixelText2890); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Paint.staticClass, _isSubpixelText2890); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSubpixelText2891; 
		public virtual void setSubpixelText(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				@__env.CallVoidMethod(this, _setSubpixelText2891, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Paint.staticClass, _setSubpixelText2891, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isUnderlineText2892; 
		public virtual bool isUnderlineText() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return @__env.CallBooleanMethod(this, _isUnderlineText2892); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Paint.staticClass, _isUnderlineText2892); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setUnderlineText2893; 
		public virtual void setUnderlineText(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				@__env.CallVoidMethod(this, _setUnderlineText2893, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Paint.staticClass, _setUnderlineText2893, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isStrikeThruText2894; 
		public virtual bool isStrikeThruText() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return @__env.CallBooleanMethod(this, _isStrikeThruText2894); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Paint.staticClass, _isStrikeThruText2894); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setStrikeThruText2895; 
		public virtual void setStrikeThruText(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				@__env.CallVoidMethod(this, _setStrikeThruText2895, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Paint.staticClass, _setStrikeThruText2895, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isFakeBoldText2896; 
		public virtual bool isFakeBoldText() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return @__env.CallBooleanMethod(this, _isFakeBoldText2896); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Paint.staticClass, _isFakeBoldText2896); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFakeBoldText2897; 
		public virtual void setFakeBoldText(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				@__env.CallVoidMethod(this, _setFakeBoldText2897, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Paint.staticClass, _setFakeBoldText2897, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isFilterBitmap2898; 
		public virtual bool isFilterBitmap() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return @__env.CallBooleanMethod(this, _isFilterBitmap2898); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Paint.staticClass, _isFilterBitmap2898); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getStyle2899; 
		public virtual android.graphics.Paint.Style getStyle() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Paint.Style>(@__env, @__env.CallObjectMethodPtr(this, _getStyle2899)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Paint.Style>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.Paint.staticClass, _getStyle2899)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setStyle2900; 
		public virtual void setStyle(android.graphics.Paint.Style arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				@__env.CallVoidMethod(this, _setStyle2900, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Paint.staticClass, _setStyle2900, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setColor2901; 
		public virtual void setColor(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				@__env.CallVoidMethod(this, _setColor2901, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Paint.staticClass, _setColor2901, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setARGB2902; 
		public virtual void setARGB(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				@__env.CallVoidMethod(this, _setARGB2902, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Paint.staticClass, _setARGB2902, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getStrokeWidth2903; 
		public virtual float getStrokeWidth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return @__env.CallFloatMethod(this, _getStrokeWidth2903); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.graphics.Paint.staticClass, _getStrokeWidth2903); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setStrokeWidth2904; 
		public virtual void setStrokeWidth(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				@__env.CallVoidMethod(this, _setStrokeWidth2904, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Paint.staticClass, _setStrokeWidth2904, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getStrokeMiter2905; 
		public virtual float getStrokeMiter() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return @__env.CallFloatMethod(this, _getStrokeMiter2905); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.graphics.Paint.staticClass, _getStrokeMiter2905); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setStrokeMiter2906; 
		public virtual void setStrokeMiter(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				@__env.CallVoidMethod(this, _setStrokeMiter2906, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Paint.staticClass, _setStrokeMiter2906, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getStrokeCap2907; 
		public virtual android.graphics.Paint.Cap getStrokeCap() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Paint.Cap>(@__env, @__env.CallObjectMethodPtr(this, _getStrokeCap2907)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Paint.Cap>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.Paint.staticClass, _getStrokeCap2907)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setStrokeCap2908; 
		public virtual void setStrokeCap(android.graphics.Paint.Cap arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				@__env.CallVoidMethod(this, _setStrokeCap2908, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Paint.staticClass, _setStrokeCap2908, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getStrokeJoin2909; 
		public virtual android.graphics.Paint.Join getStrokeJoin() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Paint.Join>(@__env, @__env.CallObjectMethodPtr(this, _getStrokeJoin2909)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Paint.Join>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.Paint.staticClass, _getStrokeJoin2909)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setStrokeJoin2910; 
		public virtual void setStrokeJoin(android.graphics.Paint.Join arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				@__env.CallVoidMethod(this, _setStrokeJoin2910, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Paint.staticClass, _setStrokeJoin2910, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFillPath2911; 
		public virtual bool getFillPath(android.graphics.Path arg0, android.graphics.Path arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return @__env.CallBooleanMethod(this, _getFillPath2911, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Paint.staticClass, _getFillPath2911, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getShader2912; 
		public virtual android.graphics.Shader getShader() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Shader>(@__env, @__env.CallObjectMethodPtr(this, _getShader2912)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Shader>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.Paint.staticClass, _getShader2912)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setShader2913; 
		public virtual android.graphics.Shader setShader(android.graphics.Shader arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Shader>(@__env, @__env.CallObjectMethodPtr(this, _setShader2913, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Shader>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.Paint.staticClass, _setShader2913, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getColorFilter2914; 
		public virtual android.graphics.ColorFilter getColorFilter() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.ColorFilter>(@__env, @__env.CallObjectMethodPtr(this, _getColorFilter2914)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.ColorFilter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.Paint.staticClass, _getColorFilter2914)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getXfermode2915; 
		public virtual android.graphics.Xfermode getXfermode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Xfermode>(@__env, @__env.CallObjectMethodPtr(this, _getXfermode2915)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Xfermode>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.Paint.staticClass, _getXfermode2915)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setXfermode2916; 
		public virtual android.graphics.Xfermode setXfermode(android.graphics.Xfermode arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Xfermode>(@__env, @__env.CallObjectMethodPtr(this, _setXfermode2916, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Xfermode>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.Paint.staticClass, _setXfermode2916, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPathEffect2917; 
		public virtual android.graphics.PathEffect getPathEffect() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.PathEffect>(@__env, @__env.CallObjectMethodPtr(this, _getPathEffect2917)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.PathEffect>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.Paint.staticClass, _getPathEffect2917)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPathEffect2918; 
		public virtual android.graphics.PathEffect setPathEffect(android.graphics.PathEffect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.PathEffect>(@__env, @__env.CallObjectMethodPtr(this, _setPathEffect2918, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.PathEffect>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.Paint.staticClass, _setPathEffect2918, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMaskFilter2919; 
		public virtual android.graphics.MaskFilter getMaskFilter() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.MaskFilter>(@__env, @__env.CallObjectMethodPtr(this, _getMaskFilter2919)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.MaskFilter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.Paint.staticClass, _getMaskFilter2919)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMaskFilter2920; 
		public virtual android.graphics.MaskFilter setMaskFilter(android.graphics.MaskFilter arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.MaskFilter>(@__env, @__env.CallObjectMethodPtr(this, _setMaskFilter2920, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.MaskFilter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.Paint.staticClass, _setMaskFilter2920, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRasterizer2921; 
		public virtual android.graphics.Rasterizer getRasterizer() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Rasterizer>(@__env, @__env.CallObjectMethodPtr(this, _getRasterizer2921)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Rasterizer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.Paint.staticClass, _getRasterizer2921)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setRasterizer2922; 
		public virtual android.graphics.Rasterizer setRasterizer(android.graphics.Rasterizer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Rasterizer>(@__env, @__env.CallObjectMethodPtr(this, _setRasterizer2922, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Rasterizer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.Paint.staticClass, _setRasterizer2922, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearShadowLayer2923; 
		public virtual void clearShadowLayer() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				@__env.CallVoidMethod(this, _clearShadowLayer2923); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Paint.staticClass, _clearShadowLayer2923); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTextAlign2924; 
		public virtual android.graphics.Paint.Align getTextAlign() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Paint.Align>(@__env, @__env.CallObjectMethodPtr(this, _getTextAlign2924)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Paint.Align>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.Paint.staticClass, _getTextAlign2924)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTextAlign2925; 
		public virtual void setTextAlign(android.graphics.Paint.Align arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				@__env.CallVoidMethod(this, _setTextAlign2925, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Paint.staticClass, _setTextAlign2925, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTextSkewX2926; 
		public virtual float getTextSkewX() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return @__env.CallFloatMethod(this, _getTextSkewX2926); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.graphics.Paint.staticClass, _getTextSkewX2926); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTextSkewX2927; 
		public virtual void setTextSkewX(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				@__env.CallVoidMethod(this, _setTextSkewX2927, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Paint.staticClass, _setTextSkewX2927, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ascent2928; 
		public virtual float ascent() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return @__env.CallFloatMethod(this, _ascent2928); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.graphics.Paint.staticClass, _ascent2928); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _descent2929; 
		public virtual float descent() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return @__env.CallFloatMethod(this, _descent2929); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.graphics.Paint.staticClass, _descent2929); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFontMetrics2930; 
		public virtual android.graphics.Paint.FontMetrics getFontMetrics() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Paint.FontMetrics>(@__env, @__env.CallObjectMethodPtr(this, _getFontMetrics2930)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Paint.FontMetrics>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.Paint.staticClass, _getFontMetrics2930)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFontMetrics2931; 
		public virtual float getFontMetrics(android.graphics.Paint.FontMetrics arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return @__env.CallFloatMethod(this, _getFontMetrics2931, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.graphics.Paint.staticClass, _getFontMetrics2931, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFontMetricsInt2932; 
		public virtual android.graphics.Paint.FontMetricsInt getFontMetricsInt() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Paint.FontMetricsInt>(@__env, @__env.CallObjectMethodPtr(this, _getFontMetricsInt2932)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Paint.FontMetricsInt>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.Paint.staticClass, _getFontMetricsInt2932)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFontMetricsInt2933; 
		public virtual int getFontMetricsInt(android.graphics.Paint.FontMetricsInt arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return @__env.CallIntMethod(this, _getFontMetricsInt2933, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.Paint.staticClass, _getFontMetricsInt2933, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFontSpacing2934; 
		public virtual float getFontSpacing() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return @__env.CallFloatMethod(this, _getFontSpacing2934); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.graphics.Paint.staticClass, _getFontSpacing2934); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _measureText2935; 
		public virtual float measureText(java.lang.String arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return @__env.CallFloatMethod(this, _measureText2935, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.graphics.Paint.staticClass, _measureText2935, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _measureText2936; 
		public virtual float measureText(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return @__env.CallFloatMethod(this, _measureText2936, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.graphics.Paint.staticClass, _measureText2936, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _measureText2937; 
		public virtual float measureText(java.lang.CharSequence arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return @__env.CallFloatMethod(this, _measureText2937, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.graphics.Paint.staticClass, _measureText2937, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _measureText2938; 
		public virtual float measureText(char[] arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return @__env.CallFloatMethod(this, _measureText2938, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.graphics.Paint.staticClass, _measureText2938, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _breakText2939; 
		public virtual int breakText(java.lang.CharSequence arg0, int arg1, int arg2, bool arg3, float arg4, float[] arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return @__env.CallIntMethod(this, _breakText2939, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg5)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.Paint.staticClass, _breakText2939, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _breakText2940; 
		public virtual int breakText(java.lang.String arg0, bool arg1, float arg2, float[] arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return @__env.CallIntMethod(this, _breakText2940, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.Paint.staticClass, _breakText2940, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _breakText2941; 
		public virtual int breakText(char[] arg0, int arg1, int arg2, float arg3, float[] arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return @__env.CallIntMethod(this, _breakText2941, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg4)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.Paint.staticClass, _breakText2941, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTextWidths2942; 
		public virtual int getTextWidths(java.lang.CharSequence arg0, int arg1, int arg2, float[] arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return @__env.CallIntMethod(this, _getTextWidths2942, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.Paint.staticClass, _getTextWidths2942, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTextWidths2943; 
		public virtual int getTextWidths(java.lang.String arg0, int arg1, int arg2, float[] arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return @__env.CallIntMethod(this, _getTextWidths2943, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.Paint.staticClass, _getTextWidths2943, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTextWidths2944; 
		public virtual int getTextWidths(java.lang.String arg0, float[] arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return @__env.CallIntMethod(this, _getTextWidths2944, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.Paint.staticClass, _getTextWidths2944, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTextWidths2945; 
		public virtual int getTextWidths(char[] arg0, int arg1, int arg2, float[] arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return @__env.CallIntMethod(this, _getTextWidths2945, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.Paint.staticClass, _getTextWidths2945, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTextPath2946; 
		public virtual void getTextPath(java.lang.String arg0, int arg1, int arg2, float arg3, float arg4, android.graphics.Path arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				@__env.CallVoidMethod(this, _getTextPath2946, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Paint.staticClass, _getTextPath2946, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTextPath2947; 
		public virtual void getTextPath(char[] arg0, int arg1, int arg2, float arg3, float arg4, android.graphics.Path arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				@__env.CallVoidMethod(this, _getTextPath2947, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Paint.staticClass, _getTextPath2947, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTextBounds2948; 
		public virtual void getTextBounds(java.lang.String arg0, int arg1, int arg2, android.graphics.Rect arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				@__env.CallVoidMethod(this, _getTextBounds2948, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Paint.staticClass, _getTextBounds2948, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTextBounds2949; 
		public virtual void getTextBounds(char[] arg0, int arg1, int arg2, android.graphics.Rect arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				@__env.CallVoidMethod(this, _getTextBounds2949, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Paint.staticClass, _getTextBounds2949, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Paint2950; 
		public Paint()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.Paint.staticClass, _Paint2950, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Paint2951; 
		public Paint(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.Paint.staticClass, _Paint2951, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Paint2952; 
		public Paint(android.graphics.Paint arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.Paint.staticClass, _Paint2952, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		public static int ANTI_ALIAS_FLAG
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int FILTER_BITMAP_FLAG
		{ 
			get 
			{ 
				return 2; 
			} 
		} 
		public static int DITHER_FLAG
		{ 
			get 
			{ 
				return 4; 
			} 
		} 
		public static int UNDERLINE_TEXT_FLAG
		{ 
			get 
			{ 
				return 8; 
			} 
		} 
		public static int STRIKE_THRU_TEXT_FLAG
		{ 
			get 
			{ 
				return 16; 
			} 
		} 
		public static int FAKE_BOLD_TEXT_FLAG
		{ 
			get 
			{ 
				return 32; 
			} 
		} 
		public static int LINEAR_TEXT_FLAG
		{ 
			get 
			{ 
				return 64; 
			} 
		} 
		public static int SUBPIXEL_TEXT_FLAG
		{ 
			get 
			{ 
				return 128; 
			} 
		} 
		public static int DEV_KERN_TEXT_FLAG
		{ 
			get 
			{ 
				return 256; 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.Paint.staticClass = @__class; 
			global::android.graphics.Paint._set2868 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "set", "(Landroid/graphics/Paint;)V"); 
			global::android.graphics.Paint._reset2869 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "reset", "()V"); 
			global::android.graphics.Paint._getFlags2870 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getFlags", "()I"); 
			global::android.graphics.Paint._setFlags2871 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setFlags", "(I)V"); 
			global::android.graphics.Paint._getColor2872 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getColor", "()I"); 
			global::android.graphics.Paint._setDither2873 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setDither", "(Z)V"); 
			global::android.graphics.Paint._setFilterBitmap2874 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setFilterBitmap", "(Z)V"); 
			global::android.graphics.Paint._setAlpha2875 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setAlpha", "(I)V"); 
			global::android.graphics.Paint._setColorFilter2876 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)Landroid/graphics/ColorFilter;"); 
			global::android.graphics.Paint._setTypeface2877 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setTypeface", "(Landroid/graphics/Typeface;)Landroid/graphics/Typeface;"); 
			global::android.graphics.Paint._getTextSize2878 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getTextSize", "()F"); 
			global::android.graphics.Paint._setTextSize2879 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setTextSize", "(F)V"); 
			global::android.graphics.Paint._getTextScaleX2880 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getTextScaleX", "()F"); 
			global::android.graphics.Paint._setTextScaleX2881 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setTextScaleX", "(F)V"); 
			global::android.graphics.Paint._getTypeface2882 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getTypeface", "()Landroid/graphics/Typeface;"); 
			global::android.graphics.Paint._setShadowLayer2883 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setShadowLayer", "(FFFI)V"); 
			global::android.graphics.Paint._getAlpha2884 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getAlpha", "()I"); 
			global::android.graphics.Paint._isAntiAlias2885 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "isAntiAlias", "()Z"); 
			global::android.graphics.Paint._setAntiAlias2886 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setAntiAlias", "(Z)V"); 
			global::android.graphics.Paint._isDither2887 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "isDither", "()Z"); 
			global::android.graphics.Paint._isLinearText2888 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "isLinearText", "()Z"); 
			global::android.graphics.Paint._setLinearText2889 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setLinearText", "(Z)V"); 
			global::android.graphics.Paint._isSubpixelText2890 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "isSubpixelText", "()Z"); 
			global::android.graphics.Paint._setSubpixelText2891 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setSubpixelText", "(Z)V"); 
			global::android.graphics.Paint._isUnderlineText2892 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "isUnderlineText", "()Z"); 
			global::android.graphics.Paint._setUnderlineText2893 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setUnderlineText", "(Z)V"); 
			global::android.graphics.Paint._isStrikeThruText2894 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "isStrikeThruText", "()Z"); 
			global::android.graphics.Paint._setStrikeThruText2895 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setStrikeThruText", "(Z)V"); 
			global::android.graphics.Paint._isFakeBoldText2896 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "isFakeBoldText", "()Z"); 
			global::android.graphics.Paint._setFakeBoldText2897 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setFakeBoldText", "(Z)V"); 
			global::android.graphics.Paint._isFilterBitmap2898 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "isFilterBitmap", "()Z"); 
			global::android.graphics.Paint._getStyle2899 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getStyle", "()Landroid/graphics/Paint$Style;"); 
			global::android.graphics.Paint._setStyle2900 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setStyle", "(Landroid/graphics/Paint$Style;)V"); 
			global::android.graphics.Paint._setColor2901 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setColor", "(I)V"); 
			global::android.graphics.Paint._setARGB2902 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setARGB", "(IIII)V"); 
			global::android.graphics.Paint._getStrokeWidth2903 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getStrokeWidth", "()F"); 
			global::android.graphics.Paint._setStrokeWidth2904 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setStrokeWidth", "(F)V"); 
			global::android.graphics.Paint._getStrokeMiter2905 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getStrokeMiter", "()F"); 
			global::android.graphics.Paint._setStrokeMiter2906 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setStrokeMiter", "(F)V"); 
			global::android.graphics.Paint._getStrokeCap2907 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getStrokeCap", "()Landroid/graphics/Paint$Cap;"); 
			global::android.graphics.Paint._setStrokeCap2908 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setStrokeCap", "(Landroid/graphics/Paint$Cap;)V"); 
			global::android.graphics.Paint._getStrokeJoin2909 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getStrokeJoin", "()Landroid/graphics/Paint$Join;"); 
			global::android.graphics.Paint._setStrokeJoin2910 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setStrokeJoin", "(Landroid/graphics/Paint$Join;)V"); 
			global::android.graphics.Paint._getFillPath2911 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getFillPath", "(Landroid/graphics/Path;Landroid/graphics/Path;)Z"); 
			global::android.graphics.Paint._getShader2912 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getShader", "()Landroid/graphics/Shader;"); 
			global::android.graphics.Paint._setShader2913 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setShader", "(Landroid/graphics/Shader;)Landroid/graphics/Shader;"); 
			global::android.graphics.Paint._getColorFilter2914 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getColorFilter", "()Landroid/graphics/ColorFilter;"); 
			global::android.graphics.Paint._getXfermode2915 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getXfermode", "()Landroid/graphics/Xfermode;"); 
			global::android.graphics.Paint._setXfermode2916 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setXfermode", "(Landroid/graphics/Xfermode;)Landroid/graphics/Xfermode;"); 
			global::android.graphics.Paint._getPathEffect2917 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getPathEffect", "()Landroid/graphics/PathEffect;"); 
			global::android.graphics.Paint._setPathEffect2918 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setPathEffect", "(Landroid/graphics/PathEffect;)Landroid/graphics/PathEffect;"); 
			global::android.graphics.Paint._getMaskFilter2919 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getMaskFilter", "()Landroid/graphics/MaskFilter;"); 
			global::android.graphics.Paint._setMaskFilter2920 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setMaskFilter", "(Landroid/graphics/MaskFilter;)Landroid/graphics/MaskFilter;"); 
			global::android.graphics.Paint._getRasterizer2921 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getRasterizer", "()Landroid/graphics/Rasterizer;"); 
			global::android.graphics.Paint._setRasterizer2922 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setRasterizer", "(Landroid/graphics/Rasterizer;)Landroid/graphics/Rasterizer;"); 
			global::android.graphics.Paint._clearShadowLayer2923 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "clearShadowLayer", "()V"); 
			global::android.graphics.Paint._getTextAlign2924 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getTextAlign", "()Landroid/graphics/Paint$Align;"); 
			global::android.graphics.Paint._setTextAlign2925 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setTextAlign", "(Landroid/graphics/Paint$Align;)V"); 
			global::android.graphics.Paint._getTextSkewX2926 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getTextSkewX", "()F"); 
			global::android.graphics.Paint._setTextSkewX2927 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setTextSkewX", "(F)V"); 
			global::android.graphics.Paint._ascent2928 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "ascent", "()F"); 
			global::android.graphics.Paint._descent2929 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "descent", "()F"); 
			global::android.graphics.Paint._getFontMetrics2930 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getFontMetrics", "()Landroid/graphics/Paint$FontMetrics;"); 
			global::android.graphics.Paint._getFontMetrics2931 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getFontMetrics", "(Landroid/graphics/Paint$FontMetrics;)F"); 
			global::android.graphics.Paint._getFontMetricsInt2932 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getFontMetricsInt", "()Landroid/graphics/Paint$FontMetricsInt;"); 
			global::android.graphics.Paint._getFontMetricsInt2933 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getFontMetricsInt", "(Landroid/graphics/Paint$FontMetricsInt;)I"); 
			global::android.graphics.Paint._getFontSpacing2934 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getFontSpacing", "()F"); 
			global::android.graphics.Paint._measureText2935 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "measureText", "(Ljava/lang/String;II)F"); 
			global::android.graphics.Paint._measureText2936 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "measureText", "(Ljava/lang/String;)F"); 
			global::android.graphics.Paint._measureText2937 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "measureText", "(Ljava/lang/CharSequence;II)F"); 
			global::android.graphics.Paint._measureText2938 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "measureText", "([CII)F"); 
			global::android.graphics.Paint._breakText2939 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "breakText", "(Ljava/lang/CharSequence;IIZF[F)I"); 
			global::android.graphics.Paint._breakText2940 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "breakText", "(Ljava/lang/String;ZF[F)I"); 
			global::android.graphics.Paint._breakText2941 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "breakText", "([CIIF[F)I"); 
			global::android.graphics.Paint._getTextWidths2942 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getTextWidths", "(Ljava/lang/CharSequence;II[F)I"); 
			global::android.graphics.Paint._getTextWidths2943 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getTextWidths", "(Ljava/lang/String;II[F)I"); 
			global::android.graphics.Paint._getTextWidths2944 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getTextWidths", "(Ljava/lang/String;[F)I"); 
			global::android.graphics.Paint._getTextWidths2945 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getTextWidths", "([CII[F)I"); 
			global::android.graphics.Paint._getTextPath2946 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getTextPath", "(Ljava/lang/String;IIFFLandroid/graphics/Path;)V"); 
			global::android.graphics.Paint._getTextPath2947 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getTextPath", "([CIIFFLandroid/graphics/Path;)V"); 
			global::android.graphics.Paint._getTextBounds2948 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getTextBounds", "(Ljava/lang/String;IILandroid/graphics/Rect;)V"); 
			global::android.graphics.Paint._getTextBounds2949 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getTextBounds", "([CIILandroid/graphics/Rect;)V"); 
			global::android.graphics.Paint._Paint2950 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "<init>", "()V"); 
			global::android.graphics.Paint._Paint2951 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "<init>", "(I)V"); 
			global::android.graphics.Paint._Paint2952 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "<init>", "(Landroid/graphics/Paint;)V"); 
		} 
	} 
} 
