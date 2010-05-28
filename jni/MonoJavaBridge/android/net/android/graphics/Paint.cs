namespace android.graphics 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Paint : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Paint() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.Paint), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.Paint.Align), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _valueOf3035; 
			public static global::android.graphics.Paint.Align valueOf(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Paint.Align>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Paint.Align.staticClass, global::android.graphics.Paint.Align._valueOf3035, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _values3036; 
			public static global::android.graphics.Paint.Align[] values() 
			{ 
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Paint.Align.staticClass, global::android.graphics.Paint.Align._values3036)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CENTER3037; 
			public static global::android.graphics.Paint.Align CENTER
			{ 
				get 
				{ 
					return default(global::android.graphics.Paint.Align); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _LEFT3038; 
			public static global::android.graphics.Paint.Align LEFT
			{ 
				get 
				{ 
					return default(global::android.graphics.Paint.Align); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _RIGHT3039; 
			public static global::android.graphics.Paint.Align RIGHT
			{ 
				get 
				{ 
					return default(global::android.graphics.Paint.Align); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.graphics.Paint.Align.staticClass = @__class; 
				global::android.graphics.Paint.Align._valueOf3035 = @__env.GetStaticMethodID(global::android.graphics.Paint.Align.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Paint$Align;"); 
				global::android.graphics.Paint.Align._values3036 = @__env.GetStaticMethodID(global::android.graphics.Paint.Align.staticClass, "values", "()[Landroid/graphics/Paint/Align;"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class Cap : java.lang.Enum
		{ 
			internal new static global::java.lang.Class staticClass; 
			static Cap() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.Paint.Cap), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _valueOf3040; 
			public static global::android.graphics.Paint.Cap valueOf(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Paint.Cap>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Paint.Cap.staticClass, global::android.graphics.Paint.Cap._valueOf3040, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _values3041; 
			public static global::android.graphics.Paint.Cap[] values() 
			{ 
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Paint.Cap.staticClass, global::android.graphics.Paint.Cap._values3041)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _BUTT3042; 
			public static global::android.graphics.Paint.Cap BUTT
			{ 
				get 
				{ 
					return default(global::android.graphics.Paint.Cap); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _ROUND3043; 
			public static global::android.graphics.Paint.Cap ROUND
			{ 
				get 
				{ 
					return default(global::android.graphics.Paint.Cap); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _SQUARE3044; 
			public static global::android.graphics.Paint.Cap SQUARE
			{ 
				get 
				{ 
					return default(global::android.graphics.Paint.Cap); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.graphics.Paint.Cap.staticClass = @__class; 
				global::android.graphics.Paint.Cap._valueOf3040 = @__env.GetStaticMethodID(global::android.graphics.Paint.Cap.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Paint$Cap;"); 
				global::android.graphics.Paint.Cap._values3041 = @__env.GetStaticMethodID(global::android.graphics.Paint.Cap.staticClass, "values", "()[Landroid/graphics/Paint/Cap;"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class FontMetrics : java.lang.Object
		{ 
			internal static global::java.lang.Class staticClass; 
			static FontMetrics() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.Paint.FontMetrics), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _FontMetrics3045; 
			public FontMetrics()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.graphics.Paint.FontMetrics.staticClass, global::android.graphics.Paint.FontMetrics._FontMetrics3045, this); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _top3046; 
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
			internal static global::net.sf.jni4net.jni.FieldId _ascent3047; 
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
			internal static global::net.sf.jni4net.jni.FieldId _descent3048; 
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
			internal static global::net.sf.jni4net.jni.FieldId _bottom3049; 
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
			internal static global::net.sf.jni4net.jni.FieldId _leading3050; 
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
				global::android.graphics.Paint.FontMetrics._FontMetrics3045 = @__env.GetMethodID(global::android.graphics.Paint.FontMetrics.staticClass, "<init>", "()V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class FontMetricsInt : java.lang.Object
		{ 
			internal static global::java.lang.Class staticClass; 
			static FontMetricsInt() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.Paint.FontMetricsInt), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _toString3051; 
			public override global::java.lang.String toString() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.graphics.Paint.FontMetricsInt)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.Paint.FontMetricsInt._toString3051)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.Paint.FontMetricsInt.staticClass, global::android.graphics.Paint.FontMetricsInt._toString3051)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _FontMetricsInt3052; 
			public FontMetricsInt()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.graphics.Paint.FontMetricsInt.staticClass, global::android.graphics.Paint.FontMetricsInt._FontMetricsInt3052, this); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _top3053; 
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
			internal static global::net.sf.jni4net.jni.FieldId _ascent3054; 
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
			internal static global::net.sf.jni4net.jni.FieldId _descent3055; 
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
			internal static global::net.sf.jni4net.jni.FieldId _bottom3056; 
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
			internal static global::net.sf.jni4net.jni.FieldId _leading3057; 
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
				global::android.graphics.Paint.FontMetricsInt._toString3051 = @__env.GetMethodID(global::android.graphics.Paint.FontMetricsInt.staticClass, "toString", "()Ljava/lang/String;"); 
				global::android.graphics.Paint.FontMetricsInt._FontMetricsInt3052 = @__env.GetMethodID(global::android.graphics.Paint.FontMetricsInt.staticClass, "<init>", "()V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class Join : java.lang.Enum
		{ 
			internal new static global::java.lang.Class staticClass; 
			static Join() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.Paint.Join), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _valueOf3058; 
			public static global::android.graphics.Paint.Join valueOf(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Paint.Join>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Paint.Join.staticClass, global::android.graphics.Paint.Join._valueOf3058, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _values3059; 
			public static global::android.graphics.Paint.Join[] values() 
			{ 
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Paint.Join.staticClass, global::android.graphics.Paint.Join._values3059)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _BEVEL3060; 
			public static global::android.graphics.Paint.Join BEVEL
			{ 
				get 
				{ 
					return default(global::android.graphics.Paint.Join); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _MITER3061; 
			public static global::android.graphics.Paint.Join MITER
			{ 
				get 
				{ 
					return default(global::android.graphics.Paint.Join); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _ROUND3062; 
			public static global::android.graphics.Paint.Join ROUND
			{ 
				get 
				{ 
					return default(global::android.graphics.Paint.Join); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.graphics.Paint.Join.staticClass = @__class; 
				global::android.graphics.Paint.Join._valueOf3058 = @__env.GetStaticMethodID(global::android.graphics.Paint.Join.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Paint$Join;"); 
				global::android.graphics.Paint.Join._values3059 = @__env.GetStaticMethodID(global::android.graphics.Paint.Join.staticClass, "values", "()[Landroid/graphics/Paint/Join;"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class Style : java.lang.Enum
		{ 
			internal new static global::java.lang.Class staticClass; 
			static Style() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.Paint.Style), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _valueOf3063; 
			public static global::android.graphics.Paint.Style valueOf(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Paint.Style>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Paint.Style.staticClass, global::android.graphics.Paint.Style._valueOf3063, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _values3064; 
			public static global::android.graphics.Paint.Style[] values() 
			{ 
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Paint.Style.staticClass, global::android.graphics.Paint.Style._values3064)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _FILL3065; 
			public static global::android.graphics.Paint.Style FILL
			{ 
				get 
				{ 
					return default(global::android.graphics.Paint.Style); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _FILL_AND_STROKE3066; 
			public static global::android.graphics.Paint.Style FILL_AND_STROKE
			{ 
				get 
				{ 
					return default(global::android.graphics.Paint.Style); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _STROKE3067; 
			public static global::android.graphics.Paint.Style STROKE
			{ 
				get 
				{ 
					return default(global::android.graphics.Paint.Style); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.graphics.Paint.Style.staticClass = @__class; 
				global::android.graphics.Paint.Style._valueOf3063 = @__env.GetStaticMethodID(global::android.graphics.Paint.Style.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Paint$Style;"); 
				global::android.graphics.Paint.Style._values3064 = @__env.GetStaticMethodID(global::android.graphics.Paint.Style.staticClass, "values", "()[Landroid/graphics/Paint/Style;"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _set3068; 
		public virtual void set(android.graphics.Paint arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				@__env.CallVoidMethod(this, global::android.graphics.Paint._set3068, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._set3068, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _reset3069; 
		public virtual void reset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				@__env.CallVoidMethod(this, global::android.graphics.Paint._reset3069); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._reset3069); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFlags3070; 
		public virtual int getFlags() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return @__env.CallIntMethod(this, global::android.graphics.Paint._getFlags3070); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getFlags3070); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFlags3071; 
		public virtual void setFlags(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				@__env.CallVoidMethod(this, global::android.graphics.Paint._setFlags3071, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setFlags3071, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getColor3072; 
		public virtual int getColor() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return @__env.CallIntMethod(this, global::android.graphics.Paint._getColor3072); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getColor3072); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDither3073; 
		public virtual void setDither(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				@__env.CallVoidMethod(this, global::android.graphics.Paint._setDither3073, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setDither3073, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFilterBitmap3074; 
		public virtual void setFilterBitmap(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				@__env.CallVoidMethod(this, global::android.graphics.Paint._setFilterBitmap3074, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setFilterBitmap3074, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAlpha3075; 
		public virtual void setAlpha(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				@__env.CallVoidMethod(this, global::android.graphics.Paint._setAlpha3075, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setAlpha3075, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setColorFilter3076; 
		public virtual global::android.graphics.ColorFilter setColorFilter(android.graphics.ColorFilter arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.ColorFilter>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.Paint._setColorFilter3076, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.ColorFilter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setColorFilter3076, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTypeface3077; 
		public virtual global::android.graphics.Typeface setTypeface(android.graphics.Typeface arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Typeface>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.Paint._setTypeface3077, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Typeface>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setTypeface3077, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTextSize3078; 
		public virtual float getTextSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return @__env.CallFloatMethod(this, global::android.graphics.Paint._getTextSize3078); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getTextSize3078); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTextSize3079; 
		public virtual void setTextSize(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				@__env.CallVoidMethod(this, global::android.graphics.Paint._setTextSize3079, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setTextSize3079, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTextScaleX3080; 
		public virtual float getTextScaleX() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return @__env.CallFloatMethod(this, global::android.graphics.Paint._getTextScaleX3080); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getTextScaleX3080); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTextScaleX3081; 
		public virtual void setTextScaleX(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				@__env.CallVoidMethod(this, global::android.graphics.Paint._setTextScaleX3081, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setTextScaleX3081, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTypeface3082; 
		public virtual global::android.graphics.Typeface getTypeface() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Typeface>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.Paint._getTypeface3082)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Typeface>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getTypeface3082)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setShadowLayer3083; 
		public virtual void setShadowLayer(float arg0, float arg1, float arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				@__env.CallVoidMethod(this, global::android.graphics.Paint._setShadowLayer3083, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setShadowLayer3083, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAlpha3084; 
		public virtual int getAlpha() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return @__env.CallIntMethod(this, global::android.graphics.Paint._getAlpha3084); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getAlpha3084); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isAntiAlias3085; 
		public virtual bool isAntiAlias() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return @__env.CallBooleanMethod(this, global::android.graphics.Paint._isAntiAlias3085); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._isAntiAlias3085); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAntiAlias3086; 
		public virtual void setAntiAlias(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				@__env.CallVoidMethod(this, global::android.graphics.Paint._setAntiAlias3086, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setAntiAlias3086, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isDither3087; 
		public virtual bool isDither() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return @__env.CallBooleanMethod(this, global::android.graphics.Paint._isDither3087); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._isDither3087); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isLinearText3088; 
		public virtual bool isLinearText() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return @__env.CallBooleanMethod(this, global::android.graphics.Paint._isLinearText3088); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._isLinearText3088); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setLinearText3089; 
		public virtual void setLinearText(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				@__env.CallVoidMethod(this, global::android.graphics.Paint._setLinearText3089, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setLinearText3089, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isSubpixelText3090; 
		public virtual bool isSubpixelText() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return @__env.CallBooleanMethod(this, global::android.graphics.Paint._isSubpixelText3090); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._isSubpixelText3090); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSubpixelText3091; 
		public virtual void setSubpixelText(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				@__env.CallVoidMethod(this, global::android.graphics.Paint._setSubpixelText3091, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setSubpixelText3091, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isUnderlineText3092; 
		public virtual bool isUnderlineText() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return @__env.CallBooleanMethod(this, global::android.graphics.Paint._isUnderlineText3092); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._isUnderlineText3092); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setUnderlineText3093; 
		public virtual void setUnderlineText(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				@__env.CallVoidMethod(this, global::android.graphics.Paint._setUnderlineText3093, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setUnderlineText3093, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isStrikeThruText3094; 
		public virtual bool isStrikeThruText() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return @__env.CallBooleanMethod(this, global::android.graphics.Paint._isStrikeThruText3094); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._isStrikeThruText3094); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setStrikeThruText3095; 
		public virtual void setStrikeThruText(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				@__env.CallVoidMethod(this, global::android.graphics.Paint._setStrikeThruText3095, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setStrikeThruText3095, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isFakeBoldText3096; 
		public virtual bool isFakeBoldText() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return @__env.CallBooleanMethod(this, global::android.graphics.Paint._isFakeBoldText3096); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._isFakeBoldText3096); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFakeBoldText3097; 
		public virtual void setFakeBoldText(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				@__env.CallVoidMethod(this, global::android.graphics.Paint._setFakeBoldText3097, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setFakeBoldText3097, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isFilterBitmap3098; 
		public virtual bool isFilterBitmap() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return @__env.CallBooleanMethod(this, global::android.graphics.Paint._isFilterBitmap3098); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._isFilterBitmap3098); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getStyle3099; 
		public virtual global::android.graphics.Paint.Style getStyle() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Paint.Style>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.Paint._getStyle3099)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Paint.Style>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getStyle3099)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setStyle3100; 
		public virtual void setStyle(android.graphics.Paint.Style arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				@__env.CallVoidMethod(this, global::android.graphics.Paint._setStyle3100, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setStyle3100, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setColor3101; 
		public virtual void setColor(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				@__env.CallVoidMethod(this, global::android.graphics.Paint._setColor3101, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setColor3101, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setARGB3102; 
		public virtual void setARGB(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				@__env.CallVoidMethod(this, global::android.graphics.Paint._setARGB3102, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setARGB3102, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getStrokeWidth3103; 
		public virtual float getStrokeWidth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return @__env.CallFloatMethod(this, global::android.graphics.Paint._getStrokeWidth3103); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getStrokeWidth3103); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setStrokeWidth3104; 
		public virtual void setStrokeWidth(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				@__env.CallVoidMethod(this, global::android.graphics.Paint._setStrokeWidth3104, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setStrokeWidth3104, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getStrokeMiter3105; 
		public virtual float getStrokeMiter() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return @__env.CallFloatMethod(this, global::android.graphics.Paint._getStrokeMiter3105); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getStrokeMiter3105); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setStrokeMiter3106; 
		public virtual void setStrokeMiter(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				@__env.CallVoidMethod(this, global::android.graphics.Paint._setStrokeMiter3106, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setStrokeMiter3106, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getStrokeCap3107; 
		public virtual global::android.graphics.Paint.Cap getStrokeCap() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Paint.Cap>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.Paint._getStrokeCap3107)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Paint.Cap>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getStrokeCap3107)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setStrokeCap3108; 
		public virtual void setStrokeCap(android.graphics.Paint.Cap arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				@__env.CallVoidMethod(this, global::android.graphics.Paint._setStrokeCap3108, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setStrokeCap3108, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getStrokeJoin3109; 
		public virtual global::android.graphics.Paint.Join getStrokeJoin() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Paint.Join>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.Paint._getStrokeJoin3109)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Paint.Join>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getStrokeJoin3109)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setStrokeJoin3110; 
		public virtual void setStrokeJoin(android.graphics.Paint.Join arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				@__env.CallVoidMethod(this, global::android.graphics.Paint._setStrokeJoin3110, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setStrokeJoin3110, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFillPath3111; 
		public virtual bool getFillPath(android.graphics.Path arg0, android.graphics.Path arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return @__env.CallBooleanMethod(this, global::android.graphics.Paint._getFillPath3111, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getFillPath3111, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getShader3112; 
		public virtual global::android.graphics.Shader getShader() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Shader>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.Paint._getShader3112)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Shader>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getShader3112)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setShader3113; 
		public virtual global::android.graphics.Shader setShader(android.graphics.Shader arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Shader>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.Paint._setShader3113, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Shader>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setShader3113, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getColorFilter3114; 
		public virtual global::android.graphics.ColorFilter getColorFilter() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.ColorFilter>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.Paint._getColorFilter3114)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.ColorFilter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getColorFilter3114)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getXfermode3115; 
		public virtual global::android.graphics.Xfermode getXfermode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Xfermode>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.Paint._getXfermode3115)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Xfermode>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getXfermode3115)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setXfermode3116; 
		public virtual global::android.graphics.Xfermode setXfermode(android.graphics.Xfermode arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Xfermode>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.Paint._setXfermode3116, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Xfermode>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setXfermode3116, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPathEffect3117; 
		public virtual global::android.graphics.PathEffect getPathEffect() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.PathEffect>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.Paint._getPathEffect3117)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.PathEffect>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getPathEffect3117)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPathEffect3118; 
		public virtual global::android.graphics.PathEffect setPathEffect(android.graphics.PathEffect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.PathEffect>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.Paint._setPathEffect3118, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.PathEffect>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setPathEffect3118, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMaskFilter3119; 
		public virtual global::android.graphics.MaskFilter getMaskFilter() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.MaskFilter>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.Paint._getMaskFilter3119)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.MaskFilter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getMaskFilter3119)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMaskFilter3120; 
		public virtual global::android.graphics.MaskFilter setMaskFilter(android.graphics.MaskFilter arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.MaskFilter>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.Paint._setMaskFilter3120, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.MaskFilter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setMaskFilter3120, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRasterizer3121; 
		public virtual global::android.graphics.Rasterizer getRasterizer() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Rasterizer>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.Paint._getRasterizer3121)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Rasterizer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getRasterizer3121)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setRasterizer3122; 
		public virtual global::android.graphics.Rasterizer setRasterizer(android.graphics.Rasterizer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Rasterizer>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.Paint._setRasterizer3122, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Rasterizer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setRasterizer3122, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearShadowLayer3123; 
		public virtual void clearShadowLayer() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				@__env.CallVoidMethod(this, global::android.graphics.Paint._clearShadowLayer3123); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._clearShadowLayer3123); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTextAlign3124; 
		public virtual global::android.graphics.Paint.Align getTextAlign() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Paint.Align>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.Paint._getTextAlign3124)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Paint.Align>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getTextAlign3124)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTextAlign3125; 
		public virtual void setTextAlign(android.graphics.Paint.Align arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				@__env.CallVoidMethod(this, global::android.graphics.Paint._setTextAlign3125, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setTextAlign3125, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTextSkewX3126; 
		public virtual float getTextSkewX() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return @__env.CallFloatMethod(this, global::android.graphics.Paint._getTextSkewX3126); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getTextSkewX3126); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTextSkewX3127; 
		public virtual void setTextSkewX(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				@__env.CallVoidMethod(this, global::android.graphics.Paint._setTextSkewX3127, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setTextSkewX3127, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ascent3128; 
		public virtual float ascent() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return @__env.CallFloatMethod(this, global::android.graphics.Paint._ascent3128); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._ascent3128); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _descent3129; 
		public virtual float descent() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return @__env.CallFloatMethod(this, global::android.graphics.Paint._descent3129); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._descent3129); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFontMetrics3130; 
		public virtual global::android.graphics.Paint.FontMetrics getFontMetrics() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Paint.FontMetrics>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.Paint._getFontMetrics3130)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Paint.FontMetrics>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getFontMetrics3130)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFontMetrics3131; 
		public virtual float getFontMetrics(android.graphics.Paint.FontMetrics arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return @__env.CallFloatMethod(this, global::android.graphics.Paint._getFontMetrics3131, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getFontMetrics3131, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFontMetricsInt3132; 
		public virtual global::android.graphics.Paint.FontMetricsInt getFontMetricsInt() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Paint.FontMetricsInt>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.Paint._getFontMetricsInt3132)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Paint.FontMetricsInt>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getFontMetricsInt3132)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFontMetricsInt3133; 
		public virtual int getFontMetricsInt(android.graphics.Paint.FontMetricsInt arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return @__env.CallIntMethod(this, global::android.graphics.Paint._getFontMetricsInt3133, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getFontMetricsInt3133, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFontSpacing3134; 
		public virtual float getFontSpacing() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return @__env.CallFloatMethod(this, global::android.graphics.Paint._getFontSpacing3134); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getFontSpacing3134); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _measureText3135; 
		public virtual float measureText(java.lang.String arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return @__env.CallFloatMethod(this, global::android.graphics.Paint._measureText3135, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._measureText3135, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _measureText3136; 
		public virtual float measureText(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return @__env.CallFloatMethod(this, global::android.graphics.Paint._measureText3136, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._measureText3136, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _measureText3137; 
		public virtual float measureText(java.lang.CharSequence arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return @__env.CallFloatMethod(this, global::android.graphics.Paint._measureText3137, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._measureText3137, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _measureText3138; 
		public virtual float measureText(char[] arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return @__env.CallFloatMethod(this, global::android.graphics.Paint._measureText3138, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._measureText3138, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _breakText3139; 
		public virtual int breakText(java.lang.CharSequence arg0, int arg1, int arg2, bool arg3, float arg4, float[] arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return @__env.CallIntMethod(this, global::android.graphics.Paint._breakText3139, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg5)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._breakText3139, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _breakText3140; 
		public virtual int breakText(java.lang.String arg0, bool arg1, float arg2, float[] arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return @__env.CallIntMethod(this, global::android.graphics.Paint._breakText3140, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._breakText3140, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _breakText3141; 
		public virtual int breakText(char[] arg0, int arg1, int arg2, float arg3, float[] arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return @__env.CallIntMethod(this, global::android.graphics.Paint._breakText3141, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg4)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._breakText3141, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTextWidths3142; 
		public virtual int getTextWidths(java.lang.CharSequence arg0, int arg1, int arg2, float[] arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return @__env.CallIntMethod(this, global::android.graphics.Paint._getTextWidths3142, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getTextWidths3142, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTextWidths3143; 
		public virtual int getTextWidths(java.lang.String arg0, int arg1, int arg2, float[] arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return @__env.CallIntMethod(this, global::android.graphics.Paint._getTextWidths3143, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getTextWidths3143, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTextWidths3144; 
		public virtual int getTextWidths(java.lang.String arg0, float[] arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return @__env.CallIntMethod(this, global::android.graphics.Paint._getTextWidths3144, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getTextWidths3144, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTextWidths3145; 
		public virtual int getTextWidths(char[] arg0, int arg1, int arg2, float[] arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				return @__env.CallIntMethod(this, global::android.graphics.Paint._getTextWidths3145, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getTextWidths3145, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTextPath3146; 
		public virtual void getTextPath(java.lang.String arg0, int arg1, int arg2, float arg3, float arg4, android.graphics.Path arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				@__env.CallVoidMethod(this, global::android.graphics.Paint._getTextPath3146, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getTextPath3146, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTextPath3147; 
		public virtual void getTextPath(char[] arg0, int arg1, int arg2, float arg3, float arg4, android.graphics.Path arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				@__env.CallVoidMethod(this, global::android.graphics.Paint._getTextPath3147, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getTextPath3147, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTextBounds3148; 
		public virtual void getTextBounds(java.lang.String arg0, int arg1, int arg2, android.graphics.Rect arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				@__env.CallVoidMethod(this, global::android.graphics.Paint._getTextBounds3148, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getTextBounds3148, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTextBounds3149; 
		public virtual void getTextBounds(char[] arg0, int arg1, int arg2, android.graphics.Rect arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Paint)) 
				@__env.CallVoidMethod(this, global::android.graphics.Paint._getTextBounds3149, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getTextBounds3149, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Paint3150; 
		public Paint()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.Paint.staticClass, global::android.graphics.Paint._Paint3150, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Paint3151; 
		public Paint(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.Paint.staticClass, global::android.graphics.Paint._Paint3151, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Paint3152; 
		public Paint(android.graphics.Paint arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.Paint.staticClass, global::android.graphics.Paint._Paint3152, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
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
			global::android.graphics.Paint._set3068 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "set", "(Landroid/graphics/Paint;)V"); 
			global::android.graphics.Paint._reset3069 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "reset", "()V"); 
			global::android.graphics.Paint._getFlags3070 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getFlags", "()I"); 
			global::android.graphics.Paint._setFlags3071 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setFlags", "(I)V"); 
			global::android.graphics.Paint._getColor3072 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getColor", "()I"); 
			global::android.graphics.Paint._setDither3073 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setDither", "(Z)V"); 
			global::android.graphics.Paint._setFilterBitmap3074 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setFilterBitmap", "(Z)V"); 
			global::android.graphics.Paint._setAlpha3075 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setAlpha", "(I)V"); 
			global::android.graphics.Paint._setColorFilter3076 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)Landroid/graphics/ColorFilter;"); 
			global::android.graphics.Paint._setTypeface3077 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setTypeface", "(Landroid/graphics/Typeface;)Landroid/graphics/Typeface;"); 
			global::android.graphics.Paint._getTextSize3078 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getTextSize", "()F"); 
			global::android.graphics.Paint._setTextSize3079 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setTextSize", "(F)V"); 
			global::android.graphics.Paint._getTextScaleX3080 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getTextScaleX", "()F"); 
			global::android.graphics.Paint._setTextScaleX3081 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setTextScaleX", "(F)V"); 
			global::android.graphics.Paint._getTypeface3082 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getTypeface", "()Landroid/graphics/Typeface;"); 
			global::android.graphics.Paint._setShadowLayer3083 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setShadowLayer", "(FFFI)V"); 
			global::android.graphics.Paint._getAlpha3084 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getAlpha", "()I"); 
			global::android.graphics.Paint._isAntiAlias3085 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "isAntiAlias", "()Z"); 
			global::android.graphics.Paint._setAntiAlias3086 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setAntiAlias", "(Z)V"); 
			global::android.graphics.Paint._isDither3087 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "isDither", "()Z"); 
			global::android.graphics.Paint._isLinearText3088 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "isLinearText", "()Z"); 
			global::android.graphics.Paint._setLinearText3089 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setLinearText", "(Z)V"); 
			global::android.graphics.Paint._isSubpixelText3090 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "isSubpixelText", "()Z"); 
			global::android.graphics.Paint._setSubpixelText3091 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setSubpixelText", "(Z)V"); 
			global::android.graphics.Paint._isUnderlineText3092 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "isUnderlineText", "()Z"); 
			global::android.graphics.Paint._setUnderlineText3093 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setUnderlineText", "(Z)V"); 
			global::android.graphics.Paint._isStrikeThruText3094 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "isStrikeThruText", "()Z"); 
			global::android.graphics.Paint._setStrikeThruText3095 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setStrikeThruText", "(Z)V"); 
			global::android.graphics.Paint._isFakeBoldText3096 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "isFakeBoldText", "()Z"); 
			global::android.graphics.Paint._setFakeBoldText3097 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setFakeBoldText", "(Z)V"); 
			global::android.graphics.Paint._isFilterBitmap3098 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "isFilterBitmap", "()Z"); 
			global::android.graphics.Paint._getStyle3099 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getStyle", "()Landroid/graphics/Paint$Style;"); 
			global::android.graphics.Paint._setStyle3100 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setStyle", "(Landroid/graphics/Paint$Style;)V"); 
			global::android.graphics.Paint._setColor3101 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setColor", "(I)V"); 
			global::android.graphics.Paint._setARGB3102 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setARGB", "(IIII)V"); 
			global::android.graphics.Paint._getStrokeWidth3103 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getStrokeWidth", "()F"); 
			global::android.graphics.Paint._setStrokeWidth3104 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setStrokeWidth", "(F)V"); 
			global::android.graphics.Paint._getStrokeMiter3105 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getStrokeMiter", "()F"); 
			global::android.graphics.Paint._setStrokeMiter3106 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setStrokeMiter", "(F)V"); 
			global::android.graphics.Paint._getStrokeCap3107 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getStrokeCap", "()Landroid/graphics/Paint$Cap;"); 
			global::android.graphics.Paint._setStrokeCap3108 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setStrokeCap", "(Landroid/graphics/Paint$Cap;)V"); 
			global::android.graphics.Paint._getStrokeJoin3109 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getStrokeJoin", "()Landroid/graphics/Paint$Join;"); 
			global::android.graphics.Paint._setStrokeJoin3110 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setStrokeJoin", "(Landroid/graphics/Paint$Join;)V"); 
			global::android.graphics.Paint._getFillPath3111 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getFillPath", "(Landroid/graphics/Path;Landroid/graphics/Path;)Z"); 
			global::android.graphics.Paint._getShader3112 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getShader", "()Landroid/graphics/Shader;"); 
			global::android.graphics.Paint._setShader3113 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setShader", "(Landroid/graphics/Shader;)Landroid/graphics/Shader;"); 
			global::android.graphics.Paint._getColorFilter3114 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getColorFilter", "()Landroid/graphics/ColorFilter;"); 
			global::android.graphics.Paint._getXfermode3115 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getXfermode", "()Landroid/graphics/Xfermode;"); 
			global::android.graphics.Paint._setXfermode3116 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setXfermode", "(Landroid/graphics/Xfermode;)Landroid/graphics/Xfermode;"); 
			global::android.graphics.Paint._getPathEffect3117 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getPathEffect", "()Landroid/graphics/PathEffect;"); 
			global::android.graphics.Paint._setPathEffect3118 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setPathEffect", "(Landroid/graphics/PathEffect;)Landroid/graphics/PathEffect;"); 
			global::android.graphics.Paint._getMaskFilter3119 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getMaskFilter", "()Landroid/graphics/MaskFilter;"); 
			global::android.graphics.Paint._setMaskFilter3120 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setMaskFilter", "(Landroid/graphics/MaskFilter;)Landroid/graphics/MaskFilter;"); 
			global::android.graphics.Paint._getRasterizer3121 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getRasterizer", "()Landroid/graphics/Rasterizer;"); 
			global::android.graphics.Paint._setRasterizer3122 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setRasterizer", "(Landroid/graphics/Rasterizer;)Landroid/graphics/Rasterizer;"); 
			global::android.graphics.Paint._clearShadowLayer3123 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "clearShadowLayer", "()V"); 
			global::android.graphics.Paint._getTextAlign3124 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getTextAlign", "()Landroid/graphics/Paint$Align;"); 
			global::android.graphics.Paint._setTextAlign3125 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setTextAlign", "(Landroid/graphics/Paint$Align;)V"); 
			global::android.graphics.Paint._getTextSkewX3126 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getTextSkewX", "()F"); 
			global::android.graphics.Paint._setTextSkewX3127 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setTextSkewX", "(F)V"); 
			global::android.graphics.Paint._ascent3128 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "ascent", "()F"); 
			global::android.graphics.Paint._descent3129 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "descent", "()F"); 
			global::android.graphics.Paint._getFontMetrics3130 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getFontMetrics", "()Landroid/graphics/Paint$FontMetrics;"); 
			global::android.graphics.Paint._getFontMetrics3131 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getFontMetrics", "(Landroid/graphics/Paint$FontMetrics;)F"); 
			global::android.graphics.Paint._getFontMetricsInt3132 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getFontMetricsInt", "()Landroid/graphics/Paint$FontMetricsInt;"); 
			global::android.graphics.Paint._getFontMetricsInt3133 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getFontMetricsInt", "(Landroid/graphics/Paint$FontMetricsInt;)I"); 
			global::android.graphics.Paint._getFontSpacing3134 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getFontSpacing", "()F"); 
			global::android.graphics.Paint._measureText3135 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "measureText", "(Ljava/lang/String;II)F"); 
			global::android.graphics.Paint._measureText3136 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "measureText", "(Ljava/lang/String;)F"); 
			global::android.graphics.Paint._measureText3137 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "measureText", "(Ljava/lang/CharSequence;II)F"); 
			global::android.graphics.Paint._measureText3138 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "measureText", "([CII)F"); 
			global::android.graphics.Paint._breakText3139 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "breakText", "(Ljava/lang/CharSequence;IIZF[F)I"); 
			global::android.graphics.Paint._breakText3140 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "breakText", "(Ljava/lang/String;ZF[F)I"); 
			global::android.graphics.Paint._breakText3141 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "breakText", "([CIIF[F)I"); 
			global::android.graphics.Paint._getTextWidths3142 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getTextWidths", "(Ljava/lang/CharSequence;II[F)I"); 
			global::android.graphics.Paint._getTextWidths3143 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getTextWidths", "(Ljava/lang/String;II[F)I"); 
			global::android.graphics.Paint._getTextWidths3144 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getTextWidths", "(Ljava/lang/String;[F)I"); 
			global::android.graphics.Paint._getTextWidths3145 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getTextWidths", "([CII[F)I"); 
			global::android.graphics.Paint._getTextPath3146 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getTextPath", "(Ljava/lang/String;IIFFLandroid/graphics/Path;)V"); 
			global::android.graphics.Paint._getTextPath3147 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getTextPath", "([CIIFFLandroid/graphics/Path;)V"); 
			global::android.graphics.Paint._getTextBounds3148 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getTextBounds", "(Ljava/lang/String;IILandroid/graphics/Rect;)V"); 
			global::android.graphics.Paint._getTextBounds3149 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getTextBounds", "([CIILandroid/graphics/Rect;)V"); 
			global::android.graphics.Paint._Paint3150 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "<init>", "()V"); 
			global::android.graphics.Paint._Paint3151 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "<init>", "(I)V"); 
			global::android.graphics.Paint._Paint3152 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "<init>", "(Landroid/graphics/Paint;)V"); 
		} 
	} 
} 
