namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Paint : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Paint()
		{
			InitJNI();
		}
		protected Paint(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Align : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Align()
			{
				InitJNI();
			}
			internal Align(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values3415;
			public static global::android.graphics.Paint.Align[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.Paint.Align>(@__env.CallStaticObjectMethod(android.graphics.Paint.Align.staticClass, global::android.graphics.Paint.Align._values3415)) as android.graphics.Paint.Align[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf3416;
			public static global::android.graphics.Paint.Align valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.Paint.Align.staticClass, global::android.graphics.Paint.Align._valueOf3416, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Paint.Align;
			}
			internal static global::MonoJavaBridge.FieldId _CENTER3417;
			public static global::android.graphics.Paint.Align CENTER
			{
				get
				{
					return default(global::android.graphics.Paint.Align);
				}
			}
			internal static global::MonoJavaBridge.FieldId _LEFT3418;
			public static global::android.graphics.Paint.Align LEFT
			{
				get
				{
					return default(global::android.graphics.Paint.Align);
				}
			}
			internal static global::MonoJavaBridge.FieldId _RIGHT3419;
			public static global::android.graphics.Paint.Align RIGHT
			{
				get
				{
					return default(global::android.graphics.Paint.Align);
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.Paint.Align.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Paint$Align"));
				global::android.graphics.Paint.Align._values3415 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Paint.Align.staticClass, "values", "()[Landroid/graphics/Paint/Align;");
				global::android.graphics.Paint.Align._valueOf3416 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Paint.Align.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Paint$Align;");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Cap : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Cap()
			{
				InitJNI();
			}
			internal Cap(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values3420;
			public static global::android.graphics.Paint.Cap[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.Paint.Cap>(@__env.CallStaticObjectMethod(android.graphics.Paint.Cap.staticClass, global::android.graphics.Paint.Cap._values3420)) as android.graphics.Paint.Cap[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf3421;
			public static global::android.graphics.Paint.Cap valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.Paint.Cap.staticClass, global::android.graphics.Paint.Cap._valueOf3421, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Paint.Cap;
			}
			internal static global::MonoJavaBridge.FieldId _BUTT3422;
			public static global::android.graphics.Paint.Cap BUTT
			{
				get
				{
					return default(global::android.graphics.Paint.Cap);
				}
			}
			internal static global::MonoJavaBridge.FieldId _ROUND3423;
			public static global::android.graphics.Paint.Cap ROUND
			{
				get
				{
					return default(global::android.graphics.Paint.Cap);
				}
			}
			internal static global::MonoJavaBridge.FieldId _SQUARE3424;
			public static global::android.graphics.Paint.Cap SQUARE
			{
				get
				{
					return default(global::android.graphics.Paint.Cap);
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.Paint.Cap.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Paint$Cap"));
				global::android.graphics.Paint.Cap._values3420 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Paint.Cap.staticClass, "values", "()[Landroid/graphics/Paint/Cap;");
				global::android.graphics.Paint.Cap._valueOf3421 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Paint.Cap.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Paint$Cap;");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class FontMetrics : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static FontMetrics()
			{
				InitJNI();
			}
			protected FontMetrics(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _FontMetrics3425;
			public FontMetrics()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Paint.FontMetrics.staticClass, global::android.graphics.Paint.FontMetrics._FontMetrics3425);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _top3426;
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
			internal static global::MonoJavaBridge.FieldId _ascent3427;
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
			internal static global::MonoJavaBridge.FieldId _descent3428;
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
			internal static global::MonoJavaBridge.FieldId _bottom3429;
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
			internal static global::MonoJavaBridge.FieldId _leading3430;
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
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.Paint.FontMetrics.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Paint$FontMetrics"));
				global::android.graphics.Paint.FontMetrics._FontMetrics3425 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.FontMetrics.staticClass, "<init>", "()V");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class FontMetricsInt : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static FontMetricsInt()
			{
				InitJNI();
			}
			protected FontMetricsInt(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _toString3431;
			public override global::java.lang.String toString() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Paint.FontMetricsInt._toString3431)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Paint.FontMetricsInt.staticClass, global::android.graphics.Paint.FontMetricsInt._toString3431)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _FontMetricsInt3432;
			public FontMetricsInt()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Paint.FontMetricsInt.staticClass, global::android.graphics.Paint.FontMetricsInt._FontMetricsInt3432);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _top3433;
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
			internal static global::MonoJavaBridge.FieldId _ascent3434;
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
			internal static global::MonoJavaBridge.FieldId _descent3435;
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
			internal static global::MonoJavaBridge.FieldId _bottom3436;
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
			internal static global::MonoJavaBridge.FieldId _leading3437;
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
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.Paint.FontMetricsInt.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Paint$FontMetricsInt"));
				global::android.graphics.Paint.FontMetricsInt._toString3431 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.FontMetricsInt.staticClass, "toString", "()Ljava/lang/String;");
				global::android.graphics.Paint.FontMetricsInt._FontMetricsInt3432 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.FontMetricsInt.staticClass, "<init>", "()V");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Join : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Join()
			{
				InitJNI();
			}
			internal Join(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values3438;
			public static global::android.graphics.Paint.Join[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.Paint.Join>(@__env.CallStaticObjectMethod(android.graphics.Paint.Join.staticClass, global::android.graphics.Paint.Join._values3438)) as android.graphics.Paint.Join[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf3439;
			public static global::android.graphics.Paint.Join valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.Paint.Join.staticClass, global::android.graphics.Paint.Join._valueOf3439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Paint.Join;
			}
			internal static global::MonoJavaBridge.FieldId _BEVEL3440;
			public static global::android.graphics.Paint.Join BEVEL
			{
				get
				{
					return default(global::android.graphics.Paint.Join);
				}
			}
			internal static global::MonoJavaBridge.FieldId _MITER3441;
			public static global::android.graphics.Paint.Join MITER
			{
				get
				{
					return default(global::android.graphics.Paint.Join);
				}
			}
			internal static global::MonoJavaBridge.FieldId _ROUND3442;
			public static global::android.graphics.Paint.Join ROUND
			{
				get
				{
					return default(global::android.graphics.Paint.Join);
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.Paint.Join.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Paint$Join"));
				global::android.graphics.Paint.Join._values3438 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Paint.Join.staticClass, "values", "()[Landroid/graphics/Paint/Join;");
				global::android.graphics.Paint.Join._valueOf3439 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Paint.Join.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Paint$Join;");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Style : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Style()
			{
				InitJNI();
			}
			internal Style(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values3443;
			public static global::android.graphics.Paint.Style[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.Paint.Style>(@__env.CallStaticObjectMethod(android.graphics.Paint.Style.staticClass, global::android.graphics.Paint.Style._values3443)) as android.graphics.Paint.Style[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf3444;
			public static global::android.graphics.Paint.Style valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.Paint.Style.staticClass, global::android.graphics.Paint.Style._valueOf3444, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Paint.Style;
			}
			internal static global::MonoJavaBridge.FieldId _FILL3445;
			public static global::android.graphics.Paint.Style FILL
			{
				get
				{
					return default(global::android.graphics.Paint.Style);
				}
			}
			internal static global::MonoJavaBridge.FieldId _FILL_AND_STROKE3446;
			public static global::android.graphics.Paint.Style FILL_AND_STROKE
			{
				get
				{
					return default(global::android.graphics.Paint.Style);
				}
			}
			internal static global::MonoJavaBridge.FieldId _STROKE3447;
			public static global::android.graphics.Paint.Style STROKE
			{
				get
				{
					return default(global::android.graphics.Paint.Style);
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.Paint.Style.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Paint$Style"));
				global::android.graphics.Paint.Style._values3443 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Paint.Style.staticClass, "values", "()[Landroid/graphics/Paint/Style;");
				global::android.graphics.Paint.Style._valueOf3444 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Paint.Style.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Paint$Style;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _finalize3448;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Paint._finalize3448);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._finalize3448);
		}
		internal static global::MonoJavaBridge.MethodId _set3449;
		public virtual void set(android.graphics.Paint arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Paint._set3449, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._set3449, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reset3450;
		public virtual void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Paint._reset3450);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._reset3450);
		}
		public new int Flags
		{
			get
			{
				return getFlags();
			}
			set
			{
				setFlags(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFlags3451;
		public virtual int getFlags() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Paint._getFlags3451);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getFlags3451);
		}
		internal static global::MonoJavaBridge.MethodId _setFlags3452;
		public virtual void setFlags(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Paint._setFlags3452, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setFlags3452, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Color
		{
			get
			{
				return getColor();
			}
			set
			{
				setColor(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getColor3453;
		public virtual int getColor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Paint._getColor3453);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getColor3453);
		}
		internal static global::MonoJavaBridge.MethodId _setDither3454;
		public virtual void setDither(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Paint._setDither3454, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setDither3454, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFilterBitmap3455;
		public virtual void setFilterBitmap(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Paint._setFilterBitmap3455, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setFilterBitmap3455, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAlpha3456;
		public virtual void setAlpha(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Paint._setAlpha3456, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setAlpha3456, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setColorFilter3457;
		public virtual global::android.graphics.ColorFilter setColorFilter(android.graphics.ColorFilter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Paint._setColorFilter3457, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.ColorFilter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setColorFilter3457, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.ColorFilter;
		}
		internal static global::MonoJavaBridge.MethodId _setTypeface3458;
		public virtual global::android.graphics.Typeface setTypeface(android.graphics.Typeface arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Paint._setTypeface3458, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Typeface;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setTypeface3458, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Typeface;
		}
		public new float TextSize
		{
			get
			{
				return getTextSize();
			}
			set
			{
				setTextSize(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTextSize3459;
		public virtual float getTextSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.graphics.Paint._getTextSize3459);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getTextSize3459);
		}
		internal static global::MonoJavaBridge.MethodId _setTextSize3460;
		public virtual void setTextSize(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Paint._setTextSize3460, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setTextSize3460, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new float TextScaleX
		{
			get
			{
				return getTextScaleX();
			}
			set
			{
				setTextScaleX(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTextScaleX3461;
		public virtual float getTextScaleX() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.graphics.Paint._getTextScaleX3461);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getTextScaleX3461);
		}
		internal static global::MonoJavaBridge.MethodId _setTextScaleX3462;
		public virtual void setTextScaleX(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Paint._setTextScaleX3462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setTextScaleX3462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.Typeface Typeface
		{
			get
			{
				return getTypeface();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTypeface3463;
		public virtual global::android.graphics.Typeface getTypeface() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Paint._getTypeface3463)) as android.graphics.Typeface;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getTypeface3463)) as android.graphics.Typeface;
		}
		internal static global::MonoJavaBridge.MethodId _setShadowLayer3464;
		public virtual void setShadowLayer(float arg0, float arg1, float arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Paint._setShadowLayer3464, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setShadowLayer3464, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public new int Alpha
		{
			get
			{
				return getAlpha();
			}
			set
			{
				setAlpha(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAlpha3465;
		public virtual int getAlpha() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Paint._getAlpha3465);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getAlpha3465);
		}
		internal static global::MonoJavaBridge.MethodId _isAntiAlias3466;
		public virtual bool isAntiAlias() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Paint._isAntiAlias3466);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._isAntiAlias3466);
		}
		internal static global::MonoJavaBridge.MethodId _setAntiAlias3467;
		public virtual void setAntiAlias(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Paint._setAntiAlias3467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setAntiAlias3467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDither3468;
		public virtual bool isDither() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Paint._isDither3468);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._isDither3468);
		}
		internal static global::MonoJavaBridge.MethodId _isLinearText3469;
		public virtual bool isLinearText() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Paint._isLinearText3469);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._isLinearText3469);
		}
		internal static global::MonoJavaBridge.MethodId _setLinearText3470;
		public virtual void setLinearText(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Paint._setLinearText3470, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setLinearText3470, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSubpixelText3471;
		public virtual bool isSubpixelText() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Paint._isSubpixelText3471);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._isSubpixelText3471);
		}
		internal static global::MonoJavaBridge.MethodId _setSubpixelText3472;
		public virtual void setSubpixelText(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Paint._setSubpixelText3472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setSubpixelText3472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isUnderlineText3473;
		public virtual bool isUnderlineText() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Paint._isUnderlineText3473);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._isUnderlineText3473);
		}
		internal static global::MonoJavaBridge.MethodId _setUnderlineText3474;
		public virtual void setUnderlineText(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Paint._setUnderlineText3474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setUnderlineText3474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isStrikeThruText3475;
		public virtual bool isStrikeThruText() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Paint._isStrikeThruText3475);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._isStrikeThruText3475);
		}
		internal static global::MonoJavaBridge.MethodId _setStrikeThruText3476;
		public virtual void setStrikeThruText(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Paint._setStrikeThruText3476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setStrikeThruText3476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isFakeBoldText3477;
		public virtual bool isFakeBoldText() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Paint._isFakeBoldText3477);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._isFakeBoldText3477);
		}
		internal static global::MonoJavaBridge.MethodId _setFakeBoldText3478;
		public virtual void setFakeBoldText(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Paint._setFakeBoldText3478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setFakeBoldText3478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isFilterBitmap3479;
		public virtual bool isFilterBitmap() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Paint._isFilterBitmap3479);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._isFilterBitmap3479);
		}
		internal static global::MonoJavaBridge.MethodId _getStyle3480;
		public virtual global::android.graphics.Paint.Style getStyle() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Paint._getStyle3480)) as android.graphics.Paint.Style;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getStyle3480)) as android.graphics.Paint.Style;
		}
		internal static global::MonoJavaBridge.MethodId _setStyle3481;
		public virtual void setStyle(android.graphics.Paint.Style arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Paint._setStyle3481, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setStyle3481, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setColor3482;
		public virtual void setColor(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Paint._setColor3482, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setColor3482, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setARGB3483;
		public virtual void setARGB(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Paint._setARGB3483, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setARGB3483, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public new float StrokeWidth
		{
			get
			{
				return getStrokeWidth();
			}
			set
			{
				setStrokeWidth(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getStrokeWidth3484;
		public virtual float getStrokeWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.graphics.Paint._getStrokeWidth3484);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getStrokeWidth3484);
		}
		internal static global::MonoJavaBridge.MethodId _setStrokeWidth3485;
		public virtual void setStrokeWidth(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Paint._setStrokeWidth3485, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setStrokeWidth3485, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new float StrokeMiter
		{
			get
			{
				return getStrokeMiter();
			}
			set
			{
				setStrokeMiter(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getStrokeMiter3486;
		public virtual float getStrokeMiter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.graphics.Paint._getStrokeMiter3486);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getStrokeMiter3486);
		}
		internal static global::MonoJavaBridge.MethodId _setStrokeMiter3487;
		public virtual void setStrokeMiter(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Paint._setStrokeMiter3487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setStrokeMiter3487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.Paint.Cap StrokeCap
		{
			get
			{
				return getStrokeCap();
			}
			set
			{
				setStrokeCap(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getStrokeCap3488;
		public virtual global::android.graphics.Paint.Cap getStrokeCap() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Paint._getStrokeCap3488)) as android.graphics.Paint.Cap;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getStrokeCap3488)) as android.graphics.Paint.Cap;
		}
		internal static global::MonoJavaBridge.MethodId _setStrokeCap3489;
		public virtual void setStrokeCap(android.graphics.Paint.Cap arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Paint._setStrokeCap3489, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setStrokeCap3489, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.Paint.Join StrokeJoin
		{
			get
			{
				return getStrokeJoin();
			}
			set
			{
				setStrokeJoin(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getStrokeJoin3490;
		public virtual global::android.graphics.Paint.Join getStrokeJoin() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Paint._getStrokeJoin3490)) as android.graphics.Paint.Join;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getStrokeJoin3490)) as android.graphics.Paint.Join;
		}
		internal static global::MonoJavaBridge.MethodId _setStrokeJoin3491;
		public virtual void setStrokeJoin(android.graphics.Paint.Join arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Paint._setStrokeJoin3491, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setStrokeJoin3491, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFillPath3492;
		public virtual bool getFillPath(android.graphics.Path arg0, android.graphics.Path arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Paint._getFillPath3492, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getFillPath3492, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::android.graphics.Shader Shader
		{
			get
			{
				return getShader();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getShader3493;
		public virtual global::android.graphics.Shader getShader() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Paint._getShader3493)) as android.graphics.Shader;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getShader3493)) as android.graphics.Shader;
		}
		internal static global::MonoJavaBridge.MethodId _setShader3494;
		public virtual global::android.graphics.Shader setShader(android.graphics.Shader arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Paint._setShader3494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Shader;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setShader3494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Shader;
		}
		public new global::android.graphics.ColorFilter ColorFilter
		{
			get
			{
				return getColorFilter();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getColorFilter3495;
		public virtual global::android.graphics.ColorFilter getColorFilter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Paint._getColorFilter3495)) as android.graphics.ColorFilter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getColorFilter3495)) as android.graphics.ColorFilter;
		}
		public new global::android.graphics.Xfermode Xfermode
		{
			get
			{
				return getXfermode();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getXfermode3496;
		public virtual global::android.graphics.Xfermode getXfermode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Paint._getXfermode3496)) as android.graphics.Xfermode;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getXfermode3496)) as android.graphics.Xfermode;
		}
		internal static global::MonoJavaBridge.MethodId _setXfermode3497;
		public virtual global::android.graphics.Xfermode setXfermode(android.graphics.Xfermode arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Paint._setXfermode3497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Xfermode;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setXfermode3497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Xfermode;
		}
		public new global::android.graphics.PathEffect PathEffect
		{
			get
			{
				return getPathEffect();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPathEffect3498;
		public virtual global::android.graphics.PathEffect getPathEffect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Paint._getPathEffect3498)) as android.graphics.PathEffect;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getPathEffect3498)) as android.graphics.PathEffect;
		}
		internal static global::MonoJavaBridge.MethodId _setPathEffect3499;
		public virtual global::android.graphics.PathEffect setPathEffect(android.graphics.PathEffect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Paint._setPathEffect3499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.PathEffect;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setPathEffect3499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.PathEffect;
		}
		public new global::android.graphics.MaskFilter MaskFilter
		{
			get
			{
				return getMaskFilter();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMaskFilter3500;
		public virtual global::android.graphics.MaskFilter getMaskFilter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Paint._getMaskFilter3500)) as android.graphics.MaskFilter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getMaskFilter3500)) as android.graphics.MaskFilter;
		}
		internal static global::MonoJavaBridge.MethodId _setMaskFilter3501;
		public virtual global::android.graphics.MaskFilter setMaskFilter(android.graphics.MaskFilter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Paint._setMaskFilter3501, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.MaskFilter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setMaskFilter3501, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.MaskFilter;
		}
		public new global::android.graphics.Rasterizer Rasterizer
		{
			get
			{
				return getRasterizer();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRasterizer3502;
		public virtual global::android.graphics.Rasterizer getRasterizer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Paint._getRasterizer3502)) as android.graphics.Rasterizer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getRasterizer3502)) as android.graphics.Rasterizer;
		}
		internal static global::MonoJavaBridge.MethodId _setRasterizer3503;
		public virtual global::android.graphics.Rasterizer setRasterizer(android.graphics.Rasterizer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Paint._setRasterizer3503, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Rasterizer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setRasterizer3503, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Rasterizer;
		}
		internal static global::MonoJavaBridge.MethodId _clearShadowLayer3504;
		public virtual void clearShadowLayer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Paint._clearShadowLayer3504);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._clearShadowLayer3504);
		}
		public new global::android.graphics.Paint.Align TextAlign
		{
			get
			{
				return getTextAlign();
			}
			set
			{
				setTextAlign(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTextAlign3505;
		public virtual global::android.graphics.Paint.Align getTextAlign() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Paint._getTextAlign3505)) as android.graphics.Paint.Align;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getTextAlign3505)) as android.graphics.Paint.Align;
		}
		internal static global::MonoJavaBridge.MethodId _setTextAlign3506;
		public virtual void setTextAlign(android.graphics.Paint.Align arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Paint._setTextAlign3506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setTextAlign3506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new float TextSkewX
		{
			get
			{
				return getTextSkewX();
			}
			set
			{
				setTextSkewX(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTextSkewX3507;
		public virtual float getTextSkewX() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.graphics.Paint._getTextSkewX3507);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getTextSkewX3507);
		}
		internal static global::MonoJavaBridge.MethodId _setTextSkewX3508;
		public virtual void setTextSkewX(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Paint._setTextSkewX3508, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setTextSkewX3508, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ascent3509;
		public virtual float ascent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.graphics.Paint._ascent3509);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._ascent3509);
		}
		internal static global::MonoJavaBridge.MethodId _descent3510;
		public virtual float descent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.graphics.Paint._descent3510);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._descent3510);
		}
		internal static global::MonoJavaBridge.MethodId _getFontMetrics3511;
		public virtual global::android.graphics.Paint.FontMetrics getFontMetrics() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Paint._getFontMetrics3511)) as android.graphics.Paint.FontMetrics;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getFontMetrics3511)) as android.graphics.Paint.FontMetrics;
		}
		internal static global::MonoJavaBridge.MethodId _getFontMetrics3512;
		public virtual float getFontMetrics(android.graphics.Paint.FontMetrics arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.graphics.Paint._getFontMetrics3512, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getFontMetrics3512, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFontMetricsInt3513;
		public virtual global::android.graphics.Paint.FontMetricsInt getFontMetricsInt() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Paint._getFontMetricsInt3513)) as android.graphics.Paint.FontMetricsInt;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getFontMetricsInt3513)) as android.graphics.Paint.FontMetricsInt;
		}
		internal static global::MonoJavaBridge.MethodId _getFontMetricsInt3514;
		public virtual int getFontMetricsInt(android.graphics.Paint.FontMetricsInt arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Paint._getFontMetricsInt3514, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getFontMetricsInt3514, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new float FontSpacing
		{
			get
			{
				return getFontSpacing();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFontSpacing3515;
		public virtual float getFontSpacing() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.graphics.Paint._getFontSpacing3515);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getFontSpacing3515);
		}
		internal static global::MonoJavaBridge.MethodId _measureText3516;
		public virtual float measureText(java.lang.String arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.graphics.Paint._measureText3516, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._measureText3516, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _measureText3517;
		public virtual float measureText(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.graphics.Paint._measureText3517, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._measureText3517, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _measureText3518;
		public virtual float measureText(java.lang.CharSequence arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.graphics.Paint._measureText3518, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._measureText3518, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public float measureText(string arg0, int arg1, int arg2)
		{
			return measureText((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		internal static global::MonoJavaBridge.MethodId _measureText3519;
		public virtual float measureText(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.graphics.Paint._measureText3519, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._measureText3519, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _breakText3520;
		public virtual int breakText(java.lang.CharSequence arg0, int arg1, int arg2, bool arg3, float arg4, float[] arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Paint._breakText3520, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._breakText3520, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		public int breakText(string arg0, int arg1, int arg2, bool arg3, float arg4, float[] arg5)
		{
			return breakText((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3, arg4, arg5);
		}
		internal static global::MonoJavaBridge.MethodId _breakText3521;
		public virtual int breakText(java.lang.String arg0, bool arg1, float arg2, float[] arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Paint._breakText3521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._breakText3521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _breakText3522;
		public virtual int breakText(char[] arg0, int arg1, int arg2, float arg3, float[] arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Paint._breakText3522, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._breakText3522, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _getTextWidths3523;
		public virtual int getTextWidths(java.lang.CharSequence arg0, int arg1, int arg2, float[] arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Paint._getTextWidths3523, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getTextWidths3523, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public int getTextWidths(string arg0, int arg1, int arg2, float[] arg3)
		{
			return getTextWidths((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3);
		}
		internal static global::MonoJavaBridge.MethodId _getTextWidths3524;
		public virtual int getTextWidths(java.lang.String arg0, int arg1, int arg2, float[] arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Paint._getTextWidths3524, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getTextWidths3524, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _getTextWidths3525;
		public virtual int getTextWidths(java.lang.String arg0, float[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Paint._getTextWidths3525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getTextWidths3525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getTextWidths3526;
		public virtual int getTextWidths(char[] arg0, int arg1, int arg2, float[] arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Paint._getTextWidths3526, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getTextWidths3526, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _getTextPath3527;
		public virtual void getTextPath(java.lang.String arg0, int arg1, int arg2, float arg3, float arg4, android.graphics.Path arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Paint._getTextPath3527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getTextPath3527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _getTextPath3528;
		public virtual void getTextPath(char[] arg0, int arg1, int arg2, float arg3, float arg4, android.graphics.Path arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Paint._getTextPath3528, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getTextPath3528, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _getTextBounds3529;
		public virtual void getTextBounds(java.lang.String arg0, int arg1, int arg2, android.graphics.Rect arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Paint._getTextBounds3529, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getTextBounds3529, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _getTextBounds3530;
		public virtual void getTextBounds(char[] arg0, int arg1, int arg2, android.graphics.Rect arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Paint._getTextBounds3530, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getTextBounds3530, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _Paint3531;
		public Paint()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Paint.staticClass, global::android.graphics.Paint._Paint3531);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Paint3532;
		public Paint(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Paint.staticClass, global::android.graphics.Paint._Paint3532, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Paint3533;
		public Paint(android.graphics.Paint arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Paint.staticClass, global::android.graphics.Paint._Paint3533, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.Paint.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Paint"));
			global::android.graphics.Paint._finalize3448 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "finalize", "()V");
			global::android.graphics.Paint._set3449 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "set", "(Landroid/graphics/Paint;)V");
			global::android.graphics.Paint._reset3450 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "reset", "()V");
			global::android.graphics.Paint._getFlags3451 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "getFlags", "()I");
			global::android.graphics.Paint._setFlags3452 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "setFlags", "(I)V");
			global::android.graphics.Paint._getColor3453 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "getColor", "()I");
			global::android.graphics.Paint._setDither3454 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "setDither", "(Z)V");
			global::android.graphics.Paint._setFilterBitmap3455 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "setFilterBitmap", "(Z)V");
			global::android.graphics.Paint._setAlpha3456 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "setAlpha", "(I)V");
			global::android.graphics.Paint._setColorFilter3457 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)Landroid/graphics/ColorFilter;");
			global::android.graphics.Paint._setTypeface3458 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "setTypeface", "(Landroid/graphics/Typeface;)Landroid/graphics/Typeface;");
			global::android.graphics.Paint._getTextSize3459 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "getTextSize", "()F");
			global::android.graphics.Paint._setTextSize3460 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "setTextSize", "(F)V");
			global::android.graphics.Paint._getTextScaleX3461 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "getTextScaleX", "()F");
			global::android.graphics.Paint._setTextScaleX3462 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "setTextScaleX", "(F)V");
			global::android.graphics.Paint._getTypeface3463 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "getTypeface", "()Landroid/graphics/Typeface;");
			global::android.graphics.Paint._setShadowLayer3464 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "setShadowLayer", "(FFFI)V");
			global::android.graphics.Paint._getAlpha3465 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "getAlpha", "()I");
			global::android.graphics.Paint._isAntiAlias3466 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "isAntiAlias", "()Z");
			global::android.graphics.Paint._setAntiAlias3467 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "setAntiAlias", "(Z)V");
			global::android.graphics.Paint._isDither3468 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "isDither", "()Z");
			global::android.graphics.Paint._isLinearText3469 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "isLinearText", "()Z");
			global::android.graphics.Paint._setLinearText3470 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "setLinearText", "(Z)V");
			global::android.graphics.Paint._isSubpixelText3471 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "isSubpixelText", "()Z");
			global::android.graphics.Paint._setSubpixelText3472 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "setSubpixelText", "(Z)V");
			global::android.graphics.Paint._isUnderlineText3473 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "isUnderlineText", "()Z");
			global::android.graphics.Paint._setUnderlineText3474 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "setUnderlineText", "(Z)V");
			global::android.graphics.Paint._isStrikeThruText3475 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "isStrikeThruText", "()Z");
			global::android.graphics.Paint._setStrikeThruText3476 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "setStrikeThruText", "(Z)V");
			global::android.graphics.Paint._isFakeBoldText3477 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "isFakeBoldText", "()Z");
			global::android.graphics.Paint._setFakeBoldText3478 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "setFakeBoldText", "(Z)V");
			global::android.graphics.Paint._isFilterBitmap3479 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "isFilterBitmap", "()Z");
			global::android.graphics.Paint._getStyle3480 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "getStyle", "()Landroid/graphics/Paint$Style;");
			global::android.graphics.Paint._setStyle3481 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "setStyle", "(Landroid/graphics/Paint$Style;)V");
			global::android.graphics.Paint._setColor3482 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "setColor", "(I)V");
			global::android.graphics.Paint._setARGB3483 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "setARGB", "(IIII)V");
			global::android.graphics.Paint._getStrokeWidth3484 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "getStrokeWidth", "()F");
			global::android.graphics.Paint._setStrokeWidth3485 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "setStrokeWidth", "(F)V");
			global::android.graphics.Paint._getStrokeMiter3486 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "getStrokeMiter", "()F");
			global::android.graphics.Paint._setStrokeMiter3487 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "setStrokeMiter", "(F)V");
			global::android.graphics.Paint._getStrokeCap3488 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "getStrokeCap", "()Landroid/graphics/Paint$Cap;");
			global::android.graphics.Paint._setStrokeCap3489 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "setStrokeCap", "(Landroid/graphics/Paint$Cap;)V");
			global::android.graphics.Paint._getStrokeJoin3490 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "getStrokeJoin", "()Landroid/graphics/Paint$Join;");
			global::android.graphics.Paint._setStrokeJoin3491 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "setStrokeJoin", "(Landroid/graphics/Paint$Join;)V");
			global::android.graphics.Paint._getFillPath3492 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "getFillPath", "(Landroid/graphics/Path;Landroid/graphics/Path;)Z");
			global::android.graphics.Paint._getShader3493 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "getShader", "()Landroid/graphics/Shader;");
			global::android.graphics.Paint._setShader3494 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "setShader", "(Landroid/graphics/Shader;)Landroid/graphics/Shader;");
			global::android.graphics.Paint._getColorFilter3495 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "getColorFilter", "()Landroid/graphics/ColorFilter;");
			global::android.graphics.Paint._getXfermode3496 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "getXfermode", "()Landroid/graphics/Xfermode;");
			global::android.graphics.Paint._setXfermode3497 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "setXfermode", "(Landroid/graphics/Xfermode;)Landroid/graphics/Xfermode;");
			global::android.graphics.Paint._getPathEffect3498 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "getPathEffect", "()Landroid/graphics/PathEffect;");
			global::android.graphics.Paint._setPathEffect3499 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "setPathEffect", "(Landroid/graphics/PathEffect;)Landroid/graphics/PathEffect;");
			global::android.graphics.Paint._getMaskFilter3500 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "getMaskFilter", "()Landroid/graphics/MaskFilter;");
			global::android.graphics.Paint._setMaskFilter3501 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "setMaskFilter", "(Landroid/graphics/MaskFilter;)Landroid/graphics/MaskFilter;");
			global::android.graphics.Paint._getRasterizer3502 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "getRasterizer", "()Landroid/graphics/Rasterizer;");
			global::android.graphics.Paint._setRasterizer3503 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "setRasterizer", "(Landroid/graphics/Rasterizer;)Landroid/graphics/Rasterizer;");
			global::android.graphics.Paint._clearShadowLayer3504 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "clearShadowLayer", "()V");
			global::android.graphics.Paint._getTextAlign3505 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "getTextAlign", "()Landroid/graphics/Paint$Align;");
			global::android.graphics.Paint._setTextAlign3506 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "setTextAlign", "(Landroid/graphics/Paint$Align;)V");
			global::android.graphics.Paint._getTextSkewX3507 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "getTextSkewX", "()F");
			global::android.graphics.Paint._setTextSkewX3508 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "setTextSkewX", "(F)V");
			global::android.graphics.Paint._ascent3509 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "ascent", "()F");
			global::android.graphics.Paint._descent3510 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "descent", "()F");
			global::android.graphics.Paint._getFontMetrics3511 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "getFontMetrics", "()Landroid/graphics/Paint$FontMetrics;");
			global::android.graphics.Paint._getFontMetrics3512 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "getFontMetrics", "(Landroid/graphics/Paint$FontMetrics;)F");
			global::android.graphics.Paint._getFontMetricsInt3513 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "getFontMetricsInt", "()Landroid/graphics/Paint$FontMetricsInt;");
			global::android.graphics.Paint._getFontMetricsInt3514 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "getFontMetricsInt", "(Landroid/graphics/Paint$FontMetricsInt;)I");
			global::android.graphics.Paint._getFontSpacing3515 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "getFontSpacing", "()F");
			global::android.graphics.Paint._measureText3516 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "measureText", "(Ljava/lang/String;II)F");
			global::android.graphics.Paint._measureText3517 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "measureText", "(Ljava/lang/String;)F");
			global::android.graphics.Paint._measureText3518 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "measureText", "(Ljava/lang/CharSequence;II)F");
			global::android.graphics.Paint._measureText3519 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "measureText", "([CII)F");
			global::android.graphics.Paint._breakText3520 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "breakText", "(Ljava/lang/CharSequence;IIZF[F)I");
			global::android.graphics.Paint._breakText3521 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "breakText", "(Ljava/lang/String;ZF[F)I");
			global::android.graphics.Paint._breakText3522 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "breakText", "([CIIF[F)I");
			global::android.graphics.Paint._getTextWidths3523 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "getTextWidths", "(Ljava/lang/CharSequence;II[F)I");
			global::android.graphics.Paint._getTextWidths3524 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "getTextWidths", "(Ljava/lang/String;II[F)I");
			global::android.graphics.Paint._getTextWidths3525 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "getTextWidths", "(Ljava/lang/String;[F)I");
			global::android.graphics.Paint._getTextWidths3526 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "getTextWidths", "([CII[F)I");
			global::android.graphics.Paint._getTextPath3527 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "getTextPath", "(Ljava/lang/String;IIFFLandroid/graphics/Path;)V");
			global::android.graphics.Paint._getTextPath3528 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "getTextPath", "([CIIFFLandroid/graphics/Path;)V");
			global::android.graphics.Paint._getTextBounds3529 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "getTextBounds", "(Ljava/lang/String;IILandroid/graphics/Rect;)V");
			global::android.graphics.Paint._getTextBounds3530 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "getTextBounds", "([CIILandroid/graphics/Rect;)V");
			global::android.graphics.Paint._Paint3531 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "<init>", "()V");
			global::android.graphics.Paint._Paint3532 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "<init>", "(I)V");
			global::android.graphics.Paint._Paint3533 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "<init>", "(Landroid/graphics/Paint;)V");
		}
	}
}
