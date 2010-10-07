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
			internal static global::net.sf.jni4net.jni.MethodId _values3234;
			public static global::android.graphics.Paint.Align[] values() 
			{
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Paint.Align.staticClass, global::android.graphics.Paint.Align._values3234));
			}
			internal static global::net.sf.jni4net.jni.MethodId _valueOf3235;
			public static global::android.graphics.Paint.Align valueOf(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Paint.Align>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Paint.Align.staticClass, global::android.graphics.Paint.Align._valueOf3235, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			}
			internal static global::net.sf.jni4net.jni.FieldId _CENTER3236;
			public static global::android.graphics.Paint.Align CENTER
			{
				get
				{
					return default(global::android.graphics.Paint.Align);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _LEFT3237;
			public static global::android.graphics.Paint.Align LEFT
			{
				get
				{
					return default(global::android.graphics.Paint.Align);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _RIGHT3238;
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
				global::android.graphics.Paint.Align._values3234 = @__env.GetStaticMethodID(global::android.graphics.Paint.Align.staticClass, "values", "()[Landroid/graphics/Paint/Align;");
				global::android.graphics.Paint.Align._valueOf3235 = @__env.GetStaticMethodID(global::android.graphics.Paint.Align.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Paint$Align;");
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
			internal static global::net.sf.jni4net.jni.MethodId _values3239;
			public static global::android.graphics.Paint.Cap[] values() 
			{
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Paint.Cap.staticClass, global::android.graphics.Paint.Cap._values3239));
			}
			internal static global::net.sf.jni4net.jni.MethodId _valueOf3240;
			public static global::android.graphics.Paint.Cap valueOf(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Paint.Cap>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Paint.Cap.staticClass, global::android.graphics.Paint.Cap._valueOf3240, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			}
			internal static global::net.sf.jni4net.jni.FieldId _BUTT3241;
			public static global::android.graphics.Paint.Cap BUTT
			{
				get
				{
					return default(global::android.graphics.Paint.Cap);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _ROUND3242;
			public static global::android.graphics.Paint.Cap ROUND
			{
				get
				{
					return default(global::android.graphics.Paint.Cap);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _SQUARE3243;
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
				global::android.graphics.Paint.Cap._values3239 = @__env.GetStaticMethodID(global::android.graphics.Paint.Cap.staticClass, "values", "()[Landroid/graphics/Paint/Cap;");
				global::android.graphics.Paint.Cap._valueOf3240 = @__env.GetStaticMethodID(global::android.graphics.Paint.Cap.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Paint$Cap;");
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
			internal static global::net.sf.jni4net.jni.MethodId _FontMetrics3244;
			public FontMetrics()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.graphics.Paint.FontMetrics.staticClass, global::android.graphics.Paint.FontMetrics._FontMetrics3244, this);
			}
			internal static global::net.sf.jni4net.jni.FieldId _top3245;
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
			internal static global::net.sf.jni4net.jni.FieldId _ascent3246;
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
			internal static global::net.sf.jni4net.jni.FieldId _descent3247;
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
			internal static global::net.sf.jni4net.jni.FieldId _bottom3248;
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
			internal static global::net.sf.jni4net.jni.FieldId _leading3249;
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
				global::android.graphics.Paint.FontMetrics._FontMetrics3244 = @__env.GetMethodID(global::android.graphics.Paint.FontMetrics.staticClass, "<init>", "()V");
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
			internal static global::net.sf.jni4net.jni.MethodId _toString3250;
			public override global::java.lang.String toString() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.Paint.FontMetricsInt._toString3250));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.Paint.FontMetricsInt.staticClass, global::android.graphics.Paint.FontMetricsInt._toString3250));
			}
			internal static global::net.sf.jni4net.jni.MethodId _FontMetricsInt3251;
			public FontMetricsInt()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.graphics.Paint.FontMetricsInt.staticClass, global::android.graphics.Paint.FontMetricsInt._FontMetricsInt3251, this);
			}
			internal static global::net.sf.jni4net.jni.FieldId _top3252;
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
			internal static global::net.sf.jni4net.jni.FieldId _ascent3253;
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
			internal static global::net.sf.jni4net.jni.FieldId _descent3254;
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
			internal static global::net.sf.jni4net.jni.FieldId _bottom3255;
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
			internal static global::net.sf.jni4net.jni.FieldId _leading3256;
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
				global::android.graphics.Paint.FontMetricsInt._toString3250 = @__env.GetMethodID(global::android.graphics.Paint.FontMetricsInt.staticClass, "toString", "()Ljava/lang/String;");
				global::android.graphics.Paint.FontMetricsInt._FontMetricsInt3251 = @__env.GetMethodID(global::android.graphics.Paint.FontMetricsInt.staticClass, "<init>", "()V");
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
			internal static global::net.sf.jni4net.jni.MethodId _values3257;
			public static global::android.graphics.Paint.Join[] values() 
			{
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Paint.Join.staticClass, global::android.graphics.Paint.Join._values3257));
			}
			internal static global::net.sf.jni4net.jni.MethodId _valueOf3258;
			public static global::android.graphics.Paint.Join valueOf(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Paint.Join>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Paint.Join.staticClass, global::android.graphics.Paint.Join._valueOf3258, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			}
			internal static global::net.sf.jni4net.jni.FieldId _BEVEL3259;
			public static global::android.graphics.Paint.Join BEVEL
			{
				get
				{
					return default(global::android.graphics.Paint.Join);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _MITER3260;
			public static global::android.graphics.Paint.Join MITER
			{
				get
				{
					return default(global::android.graphics.Paint.Join);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _ROUND3261;
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
				global::android.graphics.Paint.Join._values3257 = @__env.GetStaticMethodID(global::android.graphics.Paint.Join.staticClass, "values", "()[Landroid/graphics/Paint/Join;");
				global::android.graphics.Paint.Join._valueOf3258 = @__env.GetStaticMethodID(global::android.graphics.Paint.Join.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Paint$Join;");
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
			internal static global::net.sf.jni4net.jni.MethodId _values3262;
			public static global::android.graphics.Paint.Style[] values() 
			{
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Paint.Style.staticClass, global::android.graphics.Paint.Style._values3262));
			}
			internal static global::net.sf.jni4net.jni.MethodId _valueOf3263;
			public static global::android.graphics.Paint.Style valueOf(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Paint.Style>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Paint.Style.staticClass, global::android.graphics.Paint.Style._valueOf3263, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			}
			internal static global::net.sf.jni4net.jni.FieldId _FILL3264;
			public static global::android.graphics.Paint.Style FILL
			{
				get
				{
					return default(global::android.graphics.Paint.Style);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _FILL_AND_STROKE3265;
			public static global::android.graphics.Paint.Style FILL_AND_STROKE
			{
				get
				{
					return default(global::android.graphics.Paint.Style);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _STROKE3266;
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
				global::android.graphics.Paint.Style._values3262 = @__env.GetStaticMethodID(global::android.graphics.Paint.Style.staticClass, "values", "()[Landroid/graphics/Paint/Style;");
				global::android.graphics.Paint.Style._valueOf3263 = @__env.GetStaticMethodID(global::android.graphics.Paint.Style.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Paint$Style;");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _set3267;
		public virtual void set(android.graphics.Paint arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Paint._set3267, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._set3267, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _reset3268;
		public virtual void reset() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Paint._reset3268);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._reset3268);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFlags3269;
		public virtual int getFlags() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.Paint._getFlags3269);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getFlags3269);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFlags3270;
		public virtual void setFlags(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Paint._setFlags3270, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setFlags3270, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getColor3271;
		public virtual int getColor() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.Paint._getColor3271);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getColor3271);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDither3272;
		public virtual void setDither(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Paint._setDither3272, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setDither3272, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFilterBitmap3273;
		public virtual void setFilterBitmap(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Paint._setFilterBitmap3273, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setFilterBitmap3273, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAlpha3274;
		public virtual void setAlpha(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Paint._setAlpha3274, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setAlpha3274, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setColorFilter3275;
		public virtual global::android.graphics.ColorFilter setColorFilter(android.graphics.ColorFilter arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.ColorFilter>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.Paint._setColorFilter3275, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.ColorFilter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setColorFilter3275, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTypeface3276;
		public virtual global::android.graphics.Typeface setTypeface(android.graphics.Typeface arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Typeface>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.Paint._setTypeface3276, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Typeface>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setTypeface3276, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTextSize3277;
		public virtual float getTextSize() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.graphics.Paint._getTextSize3277);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getTextSize3277);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTextSize3278;
		public virtual void setTextSize(float arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Paint._setTextSize3278, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setTextSize3278, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTextScaleX3279;
		public virtual float getTextScaleX() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.graphics.Paint._getTextScaleX3279);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getTextScaleX3279);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTextScaleX3280;
		public virtual void setTextScaleX(float arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Paint._setTextScaleX3280, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setTextScaleX3280, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTypeface3281;
		public virtual global::android.graphics.Typeface getTypeface() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Typeface>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.Paint._getTypeface3281));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Typeface>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getTypeface3281));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setShadowLayer3282;
		public virtual void setShadowLayer(float arg0, float arg1, float arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Paint._setShadowLayer3282, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setShadowLayer3282, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAlpha3283;
		public virtual int getAlpha() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.Paint._getAlpha3283);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getAlpha3283);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isAntiAlias3284;
		public virtual bool isAntiAlias() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Paint._isAntiAlias3284);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._isAntiAlias3284);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAntiAlias3285;
		public virtual void setAntiAlias(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Paint._setAntiAlias3285, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setAntiAlias3285, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isDither3286;
		public virtual bool isDither() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Paint._isDither3286);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._isDither3286);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isLinearText3287;
		public virtual bool isLinearText() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Paint._isLinearText3287);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._isLinearText3287);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setLinearText3288;
		public virtual void setLinearText(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Paint._setLinearText3288, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setLinearText3288, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isSubpixelText3289;
		public virtual bool isSubpixelText() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Paint._isSubpixelText3289);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._isSubpixelText3289);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSubpixelText3290;
		public virtual void setSubpixelText(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Paint._setSubpixelText3290, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setSubpixelText3290, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isUnderlineText3291;
		public virtual bool isUnderlineText() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Paint._isUnderlineText3291);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._isUnderlineText3291);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setUnderlineText3292;
		public virtual void setUnderlineText(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Paint._setUnderlineText3292, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setUnderlineText3292, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isStrikeThruText3293;
		public virtual bool isStrikeThruText() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Paint._isStrikeThruText3293);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._isStrikeThruText3293);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setStrikeThruText3294;
		public virtual void setStrikeThruText(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Paint._setStrikeThruText3294, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setStrikeThruText3294, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isFakeBoldText3295;
		public virtual bool isFakeBoldText() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Paint._isFakeBoldText3295);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._isFakeBoldText3295);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFakeBoldText3296;
		public virtual void setFakeBoldText(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Paint._setFakeBoldText3296, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setFakeBoldText3296, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isFilterBitmap3297;
		public virtual bool isFilterBitmap() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Paint._isFilterBitmap3297);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._isFilterBitmap3297);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getStyle3298;
		public virtual global::android.graphics.Paint.Style getStyle() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Paint.Style>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.Paint._getStyle3298));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Paint.Style>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getStyle3298));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setStyle3299;
		public virtual void setStyle(android.graphics.Paint.Style arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Paint._setStyle3299, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setStyle3299, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setColor3300;
		public virtual void setColor(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Paint._setColor3300, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setColor3300, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setARGB3301;
		public virtual void setARGB(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Paint._setARGB3301, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setARGB3301, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getStrokeWidth3302;
		public virtual float getStrokeWidth() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.graphics.Paint._getStrokeWidth3302);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getStrokeWidth3302);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setStrokeWidth3303;
		public virtual void setStrokeWidth(float arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Paint._setStrokeWidth3303, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setStrokeWidth3303, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getStrokeMiter3304;
		public virtual float getStrokeMiter() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.graphics.Paint._getStrokeMiter3304);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getStrokeMiter3304);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setStrokeMiter3305;
		public virtual void setStrokeMiter(float arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Paint._setStrokeMiter3305, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setStrokeMiter3305, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getStrokeCap3306;
		public virtual global::android.graphics.Paint.Cap getStrokeCap() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Paint.Cap>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.Paint._getStrokeCap3306));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Paint.Cap>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getStrokeCap3306));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setStrokeCap3307;
		public virtual void setStrokeCap(android.graphics.Paint.Cap arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Paint._setStrokeCap3307, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setStrokeCap3307, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getStrokeJoin3308;
		public virtual global::android.graphics.Paint.Join getStrokeJoin() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Paint.Join>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.Paint._getStrokeJoin3308));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Paint.Join>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getStrokeJoin3308));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setStrokeJoin3309;
		public virtual void setStrokeJoin(android.graphics.Paint.Join arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Paint._setStrokeJoin3309, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setStrokeJoin3309, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFillPath3310;
		public virtual bool getFillPath(android.graphics.Path arg0, android.graphics.Path arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Paint._getFillPath3310, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getFillPath3310, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getShader3311;
		public virtual global::android.graphics.Shader getShader() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Shader>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.Paint._getShader3311));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Shader>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getShader3311));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setShader3312;
		public virtual global::android.graphics.Shader setShader(android.graphics.Shader arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Shader>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.Paint._setShader3312, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Shader>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setShader3312, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getColorFilter3313;
		public virtual global::android.graphics.ColorFilter getColorFilter() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.ColorFilter>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.Paint._getColorFilter3313));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.ColorFilter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getColorFilter3313));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getXfermode3314;
		public virtual global::android.graphics.Xfermode getXfermode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Xfermode>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.Paint._getXfermode3314));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Xfermode>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getXfermode3314));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setXfermode3315;
		public virtual global::android.graphics.Xfermode setXfermode(android.graphics.Xfermode arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Xfermode>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.Paint._setXfermode3315, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Xfermode>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setXfermode3315, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPathEffect3316;
		public virtual global::android.graphics.PathEffect getPathEffect() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.PathEffect>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.Paint._getPathEffect3316));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.PathEffect>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getPathEffect3316));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setPathEffect3317;
		public virtual global::android.graphics.PathEffect setPathEffect(android.graphics.PathEffect arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.PathEffect>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.Paint._setPathEffect3317, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.PathEffect>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setPathEffect3317, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMaskFilter3318;
		public virtual global::android.graphics.MaskFilter getMaskFilter() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.MaskFilter>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.Paint._getMaskFilter3318));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.MaskFilter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getMaskFilter3318));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setMaskFilter3319;
		public virtual global::android.graphics.MaskFilter setMaskFilter(android.graphics.MaskFilter arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.MaskFilter>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.Paint._setMaskFilter3319, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.MaskFilter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setMaskFilter3319, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getRasterizer3320;
		public virtual global::android.graphics.Rasterizer getRasterizer() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Rasterizer>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.Paint._getRasterizer3320));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Rasterizer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getRasterizer3320));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setRasterizer3321;
		public virtual global::android.graphics.Rasterizer setRasterizer(android.graphics.Rasterizer arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Rasterizer>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.Paint._setRasterizer3321, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Rasterizer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setRasterizer3321, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clearShadowLayer3322;
		public virtual void clearShadowLayer() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Paint._clearShadowLayer3322);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._clearShadowLayer3322);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTextAlign3323;
		public virtual global::android.graphics.Paint.Align getTextAlign() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Paint.Align>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.Paint._getTextAlign3323));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Paint.Align>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getTextAlign3323));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTextAlign3324;
		public virtual void setTextAlign(android.graphics.Paint.Align arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Paint._setTextAlign3324, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setTextAlign3324, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTextSkewX3325;
		public virtual float getTextSkewX() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.graphics.Paint._getTextSkewX3325);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getTextSkewX3325);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTextSkewX3326;
		public virtual void setTextSkewX(float arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Paint._setTextSkewX3326, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setTextSkewX3326, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ascent3327;
		public virtual float ascent() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.graphics.Paint._ascent3327);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._ascent3327);
		}
		internal static global::net.sf.jni4net.jni.MethodId _descent3328;
		public virtual float descent() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.graphics.Paint._descent3328);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._descent3328);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFontMetrics3329;
		public virtual global::android.graphics.Paint.FontMetrics getFontMetrics() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Paint.FontMetrics>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.Paint._getFontMetrics3329));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Paint.FontMetrics>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getFontMetrics3329));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFontMetrics3330;
		public virtual float getFontMetrics(android.graphics.Paint.FontMetrics arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.graphics.Paint._getFontMetrics3330, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getFontMetrics3330, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFontMetricsInt3331;
		public virtual global::android.graphics.Paint.FontMetricsInt getFontMetricsInt() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Paint.FontMetricsInt>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.Paint._getFontMetricsInt3331));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Paint.FontMetricsInt>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getFontMetricsInt3331));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFontMetricsInt3332;
		public virtual int getFontMetricsInt(android.graphics.Paint.FontMetricsInt arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.Paint._getFontMetricsInt3332, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getFontMetricsInt3332, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFontSpacing3333;
		public virtual float getFontSpacing() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.graphics.Paint._getFontSpacing3333);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getFontSpacing3333);
		}
		internal static global::net.sf.jni4net.jni.MethodId _measureText3334;
		public virtual float measureText(java.lang.String arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.graphics.Paint._measureText3334, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._measureText3334, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _measureText3335;
		public virtual float measureText(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.graphics.Paint._measureText3335, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._measureText3335, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _measureText3336;
		public virtual float measureText(java.lang.CharSequence arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.graphics.Paint._measureText3336, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._measureText3336, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		public float measureText(string arg0, int arg1, int arg2)
		{
			return measureText((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		internal static global::net.sf.jni4net.jni.MethodId _measureText3337;
		public virtual float measureText(char[] arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.graphics.Paint._measureText3337, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._measureText3337, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _breakText3338;
		public virtual int breakText(java.lang.CharSequence arg0, int arg1, int arg2, bool arg3, float arg4, float[] arg5) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.Paint._breakText3338, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg5));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._breakText3338, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg5));
		}
		public int breakText(string arg0, int arg1, int arg2, bool arg3, float arg4, float[] arg5)
		{
			return breakText((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3, arg4, arg5);
		}
		internal static global::net.sf.jni4net.jni.MethodId _breakText3339;
		public virtual int breakText(java.lang.String arg0, bool arg1, float arg2, float[] arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.Paint._breakText3339, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._breakText3339, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _breakText3340;
		public virtual int breakText(char[] arg0, int arg1, int arg2, float arg3, float[] arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.Paint._breakText3340, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg4));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._breakText3340, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTextWidths3341;
		public virtual int getTextWidths(java.lang.CharSequence arg0, int arg1, int arg2, float[] arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.Paint._getTextWidths3341, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getTextWidths3341, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3));
		}
		public int getTextWidths(string arg0, int arg1, int arg2, float[] arg3)
		{
			return getTextWidths((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTextWidths3342;
		public virtual int getTextWidths(java.lang.String arg0, int arg1, int arg2, float[] arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.Paint._getTextWidths3342, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getTextWidths3342, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTextWidths3343;
		public virtual int getTextWidths(java.lang.String arg0, float[] arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.Paint._getTextWidths3343, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getTextWidths3343, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTextWidths3344;
		public virtual int getTextWidths(char[] arg0, int arg1, int arg2, float[] arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.Paint._getTextWidths3344, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getTextWidths3344, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTextPath3345;
		public virtual void getTextPath(java.lang.String arg0, int arg1, int arg2, float arg3, float arg4, android.graphics.Path arg5) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Paint._getTextPath3345, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getTextPath3345, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTextPath3346;
		public virtual void getTextPath(char[] arg0, int arg1, int arg2, float arg3, float arg4, android.graphics.Path arg5) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Paint._getTextPath3346, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getTextPath3346, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTextBounds3347;
		public virtual void getTextBounds(java.lang.String arg0, int arg1, int arg2, android.graphics.Rect arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Paint._getTextBounds3347, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getTextBounds3347, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTextBounds3348;
		public virtual void getTextBounds(char[] arg0, int arg1, int arg2, android.graphics.Rect arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Paint._getTextBounds3348, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getTextBounds3348, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Paint3349;
		public Paint()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.Paint.staticClass, global::android.graphics.Paint._Paint3349, this);
		}
		internal static global::net.sf.jni4net.jni.MethodId _Paint3350;
		public Paint(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.Paint.staticClass, global::android.graphics.Paint._Paint3350, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Paint3351;
		public Paint(android.graphics.Paint arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.Paint.staticClass, global::android.graphics.Paint._Paint3351, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
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
			global::android.graphics.Paint._set3267 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "set", "(Landroid/graphics/Paint;)V");
			global::android.graphics.Paint._reset3268 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "reset", "()V");
			global::android.graphics.Paint._getFlags3269 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getFlags", "()I");
			global::android.graphics.Paint._setFlags3270 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setFlags", "(I)V");
			global::android.graphics.Paint._getColor3271 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getColor", "()I");
			global::android.graphics.Paint._setDither3272 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setDither", "(Z)V");
			global::android.graphics.Paint._setFilterBitmap3273 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setFilterBitmap", "(Z)V");
			global::android.graphics.Paint._setAlpha3274 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setAlpha", "(I)V");
			global::android.graphics.Paint._setColorFilter3275 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)Landroid/graphics/ColorFilter;");
			global::android.graphics.Paint._setTypeface3276 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setTypeface", "(Landroid/graphics/Typeface;)Landroid/graphics/Typeface;");
			global::android.graphics.Paint._getTextSize3277 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getTextSize", "()F");
			global::android.graphics.Paint._setTextSize3278 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setTextSize", "(F)V");
			global::android.graphics.Paint._getTextScaleX3279 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getTextScaleX", "()F");
			global::android.graphics.Paint._setTextScaleX3280 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setTextScaleX", "(F)V");
			global::android.graphics.Paint._getTypeface3281 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getTypeface", "()Landroid/graphics/Typeface;");
			global::android.graphics.Paint._setShadowLayer3282 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setShadowLayer", "(FFFI)V");
			global::android.graphics.Paint._getAlpha3283 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getAlpha", "()I");
			global::android.graphics.Paint._isAntiAlias3284 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "isAntiAlias", "()Z");
			global::android.graphics.Paint._setAntiAlias3285 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setAntiAlias", "(Z)V");
			global::android.graphics.Paint._isDither3286 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "isDither", "()Z");
			global::android.graphics.Paint._isLinearText3287 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "isLinearText", "()Z");
			global::android.graphics.Paint._setLinearText3288 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setLinearText", "(Z)V");
			global::android.graphics.Paint._isSubpixelText3289 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "isSubpixelText", "()Z");
			global::android.graphics.Paint._setSubpixelText3290 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setSubpixelText", "(Z)V");
			global::android.graphics.Paint._isUnderlineText3291 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "isUnderlineText", "()Z");
			global::android.graphics.Paint._setUnderlineText3292 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setUnderlineText", "(Z)V");
			global::android.graphics.Paint._isStrikeThruText3293 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "isStrikeThruText", "()Z");
			global::android.graphics.Paint._setStrikeThruText3294 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setStrikeThruText", "(Z)V");
			global::android.graphics.Paint._isFakeBoldText3295 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "isFakeBoldText", "()Z");
			global::android.graphics.Paint._setFakeBoldText3296 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setFakeBoldText", "(Z)V");
			global::android.graphics.Paint._isFilterBitmap3297 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "isFilterBitmap", "()Z");
			global::android.graphics.Paint._getStyle3298 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getStyle", "()Landroid/graphics/Paint$Style;");
			global::android.graphics.Paint._setStyle3299 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setStyle", "(Landroid/graphics/Paint$Style;)V");
			global::android.graphics.Paint._setColor3300 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setColor", "(I)V");
			global::android.graphics.Paint._setARGB3301 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setARGB", "(IIII)V");
			global::android.graphics.Paint._getStrokeWidth3302 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getStrokeWidth", "()F");
			global::android.graphics.Paint._setStrokeWidth3303 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setStrokeWidth", "(F)V");
			global::android.graphics.Paint._getStrokeMiter3304 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getStrokeMiter", "()F");
			global::android.graphics.Paint._setStrokeMiter3305 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setStrokeMiter", "(F)V");
			global::android.graphics.Paint._getStrokeCap3306 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getStrokeCap", "()Landroid/graphics/Paint$Cap;");
			global::android.graphics.Paint._setStrokeCap3307 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setStrokeCap", "(Landroid/graphics/Paint$Cap;)V");
			global::android.graphics.Paint._getStrokeJoin3308 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getStrokeJoin", "()Landroid/graphics/Paint$Join;");
			global::android.graphics.Paint._setStrokeJoin3309 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setStrokeJoin", "(Landroid/graphics/Paint$Join;)V");
			global::android.graphics.Paint._getFillPath3310 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getFillPath", "(Landroid/graphics/Path;Landroid/graphics/Path;)Z");
			global::android.graphics.Paint._getShader3311 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getShader", "()Landroid/graphics/Shader;");
			global::android.graphics.Paint._setShader3312 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setShader", "(Landroid/graphics/Shader;)Landroid/graphics/Shader;");
			global::android.graphics.Paint._getColorFilter3313 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getColorFilter", "()Landroid/graphics/ColorFilter;");
			global::android.graphics.Paint._getXfermode3314 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getXfermode", "()Landroid/graphics/Xfermode;");
			global::android.graphics.Paint._setXfermode3315 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setXfermode", "(Landroid/graphics/Xfermode;)Landroid/graphics/Xfermode;");
			global::android.graphics.Paint._getPathEffect3316 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getPathEffect", "()Landroid/graphics/PathEffect;");
			global::android.graphics.Paint._setPathEffect3317 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setPathEffect", "(Landroid/graphics/PathEffect;)Landroid/graphics/PathEffect;");
			global::android.graphics.Paint._getMaskFilter3318 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getMaskFilter", "()Landroid/graphics/MaskFilter;");
			global::android.graphics.Paint._setMaskFilter3319 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setMaskFilter", "(Landroid/graphics/MaskFilter;)Landroid/graphics/MaskFilter;");
			global::android.graphics.Paint._getRasterizer3320 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getRasterizer", "()Landroid/graphics/Rasterizer;");
			global::android.graphics.Paint._setRasterizer3321 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setRasterizer", "(Landroid/graphics/Rasterizer;)Landroid/graphics/Rasterizer;");
			global::android.graphics.Paint._clearShadowLayer3322 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "clearShadowLayer", "()V");
			global::android.graphics.Paint._getTextAlign3323 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getTextAlign", "()Landroid/graphics/Paint$Align;");
			global::android.graphics.Paint._setTextAlign3324 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setTextAlign", "(Landroid/graphics/Paint$Align;)V");
			global::android.graphics.Paint._getTextSkewX3325 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getTextSkewX", "()F");
			global::android.graphics.Paint._setTextSkewX3326 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "setTextSkewX", "(F)V");
			global::android.graphics.Paint._ascent3327 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "ascent", "()F");
			global::android.graphics.Paint._descent3328 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "descent", "()F");
			global::android.graphics.Paint._getFontMetrics3329 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getFontMetrics", "()Landroid/graphics/Paint$FontMetrics;");
			global::android.graphics.Paint._getFontMetrics3330 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getFontMetrics", "(Landroid/graphics/Paint$FontMetrics;)F");
			global::android.graphics.Paint._getFontMetricsInt3331 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getFontMetricsInt", "()Landroid/graphics/Paint$FontMetricsInt;");
			global::android.graphics.Paint._getFontMetricsInt3332 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getFontMetricsInt", "(Landroid/graphics/Paint$FontMetricsInt;)I");
			global::android.graphics.Paint._getFontSpacing3333 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getFontSpacing", "()F");
			global::android.graphics.Paint._measureText3334 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "measureText", "(Ljava/lang/String;II)F");
			global::android.graphics.Paint._measureText3335 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "measureText", "(Ljava/lang/String;)F");
			global::android.graphics.Paint._measureText3336 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "measureText", "(Ljava/lang/CharSequence;II)F");
			global::android.graphics.Paint._measureText3337 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "measureText", "([CII)F");
			global::android.graphics.Paint._breakText3338 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "breakText", "(Ljava/lang/CharSequence;IIZF[F)I");
			global::android.graphics.Paint._breakText3339 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "breakText", "(Ljava/lang/String;ZF[F)I");
			global::android.graphics.Paint._breakText3340 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "breakText", "([CIIF[F)I");
			global::android.graphics.Paint._getTextWidths3341 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getTextWidths", "(Ljava/lang/CharSequence;II[F)I");
			global::android.graphics.Paint._getTextWidths3342 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getTextWidths", "(Ljava/lang/String;II[F)I");
			global::android.graphics.Paint._getTextWidths3343 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getTextWidths", "(Ljava/lang/String;[F)I");
			global::android.graphics.Paint._getTextWidths3344 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getTextWidths", "([CII[F)I");
			global::android.graphics.Paint._getTextPath3345 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getTextPath", "(Ljava/lang/String;IIFFLandroid/graphics/Path;)V");
			global::android.graphics.Paint._getTextPath3346 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getTextPath", "([CIIFFLandroid/graphics/Path;)V");
			global::android.graphics.Paint._getTextBounds3347 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getTextBounds", "(Ljava/lang/String;IILandroid/graphics/Rect;)V");
			global::android.graphics.Paint._getTextBounds3348 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "getTextBounds", "([CIILandroid/graphics/Rect;)V");
			global::android.graphics.Paint._Paint3349 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "<init>", "()V");
			global::android.graphics.Paint._Paint3350 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "<init>", "(I)V");
			global::android.graphics.Paint._Paint3351 = @__env.GetMethodID(global::android.graphics.Paint.staticClass, "<init>", "(Landroid/graphics/Paint;)V");
		}
	}
}
