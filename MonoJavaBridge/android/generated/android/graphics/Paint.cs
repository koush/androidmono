namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Paint : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Paint(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Align : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal Align(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values5386;
			public static global::android.graphics.Paint.Align[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.Paint.Align>(@__env.CallStaticObjectMethod(android.graphics.Paint.Align.staticClass, global::android.graphics.Paint.Align._values5386)) as android.graphics.Paint.Align[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf5387;
			public static global::android.graphics.Paint.Align valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Paint.Align>(@__env.CallStaticObjectMethod(android.graphics.Paint.Align.staticClass, global::android.graphics.Paint.Align._valueOf5387, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Paint.Align;
			}
			internal static global::MonoJavaBridge.FieldId _CENTER5388;
			public static global::android.graphics.Paint.Align CENTER
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Paint.Align>(@__env.GetStaticObjectField(global::android.graphics.Paint.Align.staticClass, _CENTER5388)) as android.graphics.Paint.Align;
				}
			}
			internal static global::MonoJavaBridge.FieldId _LEFT5389;
			public static global::android.graphics.Paint.Align LEFT
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Paint.Align>(@__env.GetStaticObjectField(global::android.graphics.Paint.Align.staticClass, _LEFT5389)) as android.graphics.Paint.Align;
				}
			}
			internal static global::MonoJavaBridge.FieldId _RIGHT5390;
			public static global::android.graphics.Paint.Align RIGHT
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Paint.Align>(@__env.GetStaticObjectField(global::android.graphics.Paint.Align.staticClass, _RIGHT5390)) as android.graphics.Paint.Align;
				}
			}
			static Align()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.Paint.Align.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Paint$Align"));
				global::android.graphics.Paint.Align._values5386 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Paint.Align.staticClass, "values", "()[Landroid/graphics/Paint/Align;");
				global::android.graphics.Paint.Align._valueOf5387 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Paint.Align.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Paint$Align;");
				global::android.graphics.Paint.Align._CENTER5388 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Paint.Align.staticClass, "CENTER", "Landroid/graphics/Paint$Align;");
				global::android.graphics.Paint.Align._LEFT5389 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Paint.Align.staticClass, "LEFT", "Landroid/graphics/Paint$Align;");
				global::android.graphics.Paint.Align._RIGHT5390 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Paint.Align.staticClass, "RIGHT", "Landroid/graphics/Paint$Align;");
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Cap : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal Cap(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values5391;
			public static global::android.graphics.Paint.Cap[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.Paint.Cap>(@__env.CallStaticObjectMethod(android.graphics.Paint.Cap.staticClass, global::android.graphics.Paint.Cap._values5391)) as android.graphics.Paint.Cap[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf5392;
			public static global::android.graphics.Paint.Cap valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Paint.Cap>(@__env.CallStaticObjectMethod(android.graphics.Paint.Cap.staticClass, global::android.graphics.Paint.Cap._valueOf5392, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Paint.Cap;
			}
			internal static global::MonoJavaBridge.FieldId _BUTT5393;
			public static global::android.graphics.Paint.Cap BUTT
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Paint.Cap>(@__env.GetStaticObjectField(global::android.graphics.Paint.Cap.staticClass, _BUTT5393)) as android.graphics.Paint.Cap;
				}
			}
			internal static global::MonoJavaBridge.FieldId _ROUND5394;
			public static global::android.graphics.Paint.Cap ROUND
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Paint.Cap>(@__env.GetStaticObjectField(global::android.graphics.Paint.Cap.staticClass, _ROUND5394)) as android.graphics.Paint.Cap;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SQUARE5395;
			public static global::android.graphics.Paint.Cap SQUARE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Paint.Cap>(@__env.GetStaticObjectField(global::android.graphics.Paint.Cap.staticClass, _SQUARE5395)) as android.graphics.Paint.Cap;
				}
			}
			static Cap()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.Paint.Cap.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Paint$Cap"));
				global::android.graphics.Paint.Cap._values5391 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Paint.Cap.staticClass, "values", "()[Landroid/graphics/Paint/Cap;");
				global::android.graphics.Paint.Cap._valueOf5392 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Paint.Cap.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Paint$Cap;");
				global::android.graphics.Paint.Cap._BUTT5393 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Paint.Cap.staticClass, "BUTT", "Landroid/graphics/Paint$Cap;");
				global::android.graphics.Paint.Cap._ROUND5394 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Paint.Cap.staticClass, "ROUND", "Landroid/graphics/Paint$Cap;");
				global::android.graphics.Paint.Cap._SQUARE5395 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Paint.Cap.staticClass, "SQUARE", "Landroid/graphics/Paint$Cap;");
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class FontMetrics : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected FontMetrics(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _FontMetrics5396;
			public FontMetrics() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Paint.FontMetrics.staticClass, global::android.graphics.Paint.FontMetrics._FontMetrics5396);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _top5397;
			public float top
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetFloatField(this.JvmHandle, _top5397);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _ascent5398;
			public float ascent
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetFloatField(this.JvmHandle, _ascent5398);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _descent5399;
			public float descent
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetFloatField(this.JvmHandle, _descent5399);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _bottom5400;
			public float bottom
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetFloatField(this.JvmHandle, _bottom5400);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _leading5401;
			public float leading
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetFloatField(this.JvmHandle, _leading5401);
				}
				set
				{
				}
			}
			static FontMetrics()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.Paint.FontMetrics.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Paint$FontMetrics"));
				global::android.graphics.Paint.FontMetrics._FontMetrics5396 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.FontMetrics.staticClass, "<init>", "()V");
				global::android.graphics.Paint.FontMetrics._top5397 = @__env.GetFieldIDNoThrow(global::android.graphics.Paint.FontMetrics.staticClass, "top", "F");
				global::android.graphics.Paint.FontMetrics._ascent5398 = @__env.GetFieldIDNoThrow(global::android.graphics.Paint.FontMetrics.staticClass, "ascent", "F");
				global::android.graphics.Paint.FontMetrics._descent5399 = @__env.GetFieldIDNoThrow(global::android.graphics.Paint.FontMetrics.staticClass, "descent", "F");
				global::android.graphics.Paint.FontMetrics._bottom5400 = @__env.GetFieldIDNoThrow(global::android.graphics.Paint.FontMetrics.staticClass, "bottom", "F");
				global::android.graphics.Paint.FontMetrics._leading5401 = @__env.GetFieldIDNoThrow(global::android.graphics.Paint.FontMetrics.staticClass, "leading", "F");
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class FontMetricsInt : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected FontMetricsInt(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _toString5402;
			public override global::java.lang.String toString()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Paint.FontMetricsInt._toString5402)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Paint.FontMetricsInt.staticClass, global::android.graphics.Paint.FontMetricsInt._toString5402)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _FontMetricsInt5403;
			public FontMetricsInt() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Paint.FontMetricsInt.staticClass, global::android.graphics.Paint.FontMetricsInt._FontMetricsInt5403);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _top5404;
			public int top
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _top5404);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _ascent5405;
			public int ascent
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _ascent5405);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _descent5406;
			public int descent
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _descent5406);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _bottom5407;
			public int bottom
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _bottom5407);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _leading5408;
			public int leading
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _leading5408);
				}
				set
				{
				}
			}
			static FontMetricsInt()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.Paint.FontMetricsInt.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Paint$FontMetricsInt"));
				global::android.graphics.Paint.FontMetricsInt._toString5402 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.FontMetricsInt.staticClass, "toString", "()Ljava/lang/String;");
				global::android.graphics.Paint.FontMetricsInt._FontMetricsInt5403 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.FontMetricsInt.staticClass, "<init>", "()V");
				global::android.graphics.Paint.FontMetricsInt._top5404 = @__env.GetFieldIDNoThrow(global::android.graphics.Paint.FontMetricsInt.staticClass, "top", "I");
				global::android.graphics.Paint.FontMetricsInt._ascent5405 = @__env.GetFieldIDNoThrow(global::android.graphics.Paint.FontMetricsInt.staticClass, "ascent", "I");
				global::android.graphics.Paint.FontMetricsInt._descent5406 = @__env.GetFieldIDNoThrow(global::android.graphics.Paint.FontMetricsInt.staticClass, "descent", "I");
				global::android.graphics.Paint.FontMetricsInt._bottom5407 = @__env.GetFieldIDNoThrow(global::android.graphics.Paint.FontMetricsInt.staticClass, "bottom", "I");
				global::android.graphics.Paint.FontMetricsInt._leading5408 = @__env.GetFieldIDNoThrow(global::android.graphics.Paint.FontMetricsInt.staticClass, "leading", "I");
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Join : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal Join(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values5409;
			public static global::android.graphics.Paint.Join[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.Paint.Join>(@__env.CallStaticObjectMethod(android.graphics.Paint.Join.staticClass, global::android.graphics.Paint.Join._values5409)) as android.graphics.Paint.Join[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf5410;
			public static global::android.graphics.Paint.Join valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Paint.Join>(@__env.CallStaticObjectMethod(android.graphics.Paint.Join.staticClass, global::android.graphics.Paint.Join._valueOf5410, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Paint.Join;
			}
			internal static global::MonoJavaBridge.FieldId _BEVEL5411;
			public static global::android.graphics.Paint.Join BEVEL
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Paint.Join>(@__env.GetStaticObjectField(global::android.graphics.Paint.Join.staticClass, _BEVEL5411)) as android.graphics.Paint.Join;
				}
			}
			internal static global::MonoJavaBridge.FieldId _MITER5412;
			public static global::android.graphics.Paint.Join MITER
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Paint.Join>(@__env.GetStaticObjectField(global::android.graphics.Paint.Join.staticClass, _MITER5412)) as android.graphics.Paint.Join;
				}
			}
			internal static global::MonoJavaBridge.FieldId _ROUND5413;
			public static global::android.graphics.Paint.Join ROUND
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Paint.Join>(@__env.GetStaticObjectField(global::android.graphics.Paint.Join.staticClass, _ROUND5413)) as android.graphics.Paint.Join;
				}
			}
			static Join()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.Paint.Join.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Paint$Join"));
				global::android.graphics.Paint.Join._values5409 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Paint.Join.staticClass, "values", "()[Landroid/graphics/Paint/Join;");
				global::android.graphics.Paint.Join._valueOf5410 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Paint.Join.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Paint$Join;");
				global::android.graphics.Paint.Join._BEVEL5411 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Paint.Join.staticClass, "BEVEL", "Landroid/graphics/Paint$Join;");
				global::android.graphics.Paint.Join._MITER5412 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Paint.Join.staticClass, "MITER", "Landroid/graphics/Paint$Join;");
				global::android.graphics.Paint.Join._ROUND5413 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Paint.Join.staticClass, "ROUND", "Landroid/graphics/Paint$Join;");
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Style : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal Style(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values5414;
			public static global::android.graphics.Paint.Style[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.Paint.Style>(@__env.CallStaticObjectMethod(android.graphics.Paint.Style.staticClass, global::android.graphics.Paint.Style._values5414)) as android.graphics.Paint.Style[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf5415;
			public static global::android.graphics.Paint.Style valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Paint.Style>(@__env.CallStaticObjectMethod(android.graphics.Paint.Style.staticClass, global::android.graphics.Paint.Style._valueOf5415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Paint.Style;
			}
			internal static global::MonoJavaBridge.FieldId _FILL5416;
			public static global::android.graphics.Paint.Style FILL
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Paint.Style>(@__env.GetStaticObjectField(global::android.graphics.Paint.Style.staticClass, _FILL5416)) as android.graphics.Paint.Style;
				}
			}
			internal static global::MonoJavaBridge.FieldId _FILL_AND_STROKE5417;
			public static global::android.graphics.Paint.Style FILL_AND_STROKE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Paint.Style>(@__env.GetStaticObjectField(global::android.graphics.Paint.Style.staticClass, _FILL_AND_STROKE5417)) as android.graphics.Paint.Style;
				}
			}
			internal static global::MonoJavaBridge.FieldId _STROKE5418;
			public static global::android.graphics.Paint.Style STROKE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Paint.Style>(@__env.GetStaticObjectField(global::android.graphics.Paint.Style.staticClass, _STROKE5418)) as android.graphics.Paint.Style;
				}
			}
			static Style()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.Paint.Style.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Paint$Style"));
				global::android.graphics.Paint.Style._values5414 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Paint.Style.staticClass, "values", "()[Landroid/graphics/Paint/Style;");
				global::android.graphics.Paint.Style._valueOf5415 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Paint.Style.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Paint$Style;");
				global::android.graphics.Paint.Style._FILL5416 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Paint.Style.staticClass, "FILL", "Landroid/graphics/Paint$Style;");
				global::android.graphics.Paint.Style._FILL_AND_STROKE5417 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Paint.Style.staticClass, "FILL_AND_STROKE", "Landroid/graphics/Paint$Style;");
				global::android.graphics.Paint.Style._STROKE5418 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Paint.Style.staticClass, "STROKE", "Landroid/graphics/Paint$Style;");
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _finalize5419;
		protected override void finalize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Paint._finalize5419);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._finalize5419);
		}
		internal static global::MonoJavaBridge.MethodId _set5420;
		public virtual void set(android.graphics.Paint arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Paint._set5420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._set5420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reset5421;
		public virtual void reset()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Paint._reset5421);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._reset5421);
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
		internal static global::MonoJavaBridge.MethodId _getFlags5422;
		public virtual int getFlags()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Paint._getFlags5422);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getFlags5422);
		}
		internal static global::MonoJavaBridge.MethodId _setFlags5423;
		public virtual void setFlags(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Paint._setFlags5423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setFlags5423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getColor5424;
		public virtual int getColor()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Paint._getColor5424);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getColor5424);
		}
		public new bool Dither
		{
			set
			{
				setDither(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setDither5425;
		public virtual void setDither(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Paint._setDither5425, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setDither5425, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool FilterBitmap
		{
			set
			{
				setFilterBitmap(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setFilterBitmap5426;
		public virtual void setFilterBitmap(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Paint._setFilterBitmap5426, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setFilterBitmap5426, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAlpha5427;
		public virtual void setAlpha(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Paint._setAlpha5427, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setAlpha5427, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setColorFilter5428;
		public virtual global::android.graphics.ColorFilter setColorFilter(android.graphics.ColorFilter arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Paint._setColorFilter5428, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.ColorFilter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setColorFilter5428, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.ColorFilter;
		}
		internal static global::MonoJavaBridge.MethodId _setTypeface5429;
		public virtual global::android.graphics.Typeface setTypeface(android.graphics.Typeface arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Paint._setTypeface5429, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Typeface;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setTypeface5429, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Typeface;
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
		internal static global::MonoJavaBridge.MethodId _getTextSize5430;
		public virtual float getTextSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.graphics.Paint._getTextSize5430);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getTextSize5430);
		}
		internal static global::MonoJavaBridge.MethodId _setTextSize5431;
		public virtual void setTextSize(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Paint._setTextSize5431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setTextSize5431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getTextScaleX5432;
		public virtual float getTextScaleX()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.graphics.Paint._getTextScaleX5432);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getTextScaleX5432);
		}
		internal static global::MonoJavaBridge.MethodId _setTextScaleX5433;
		public virtual void setTextScaleX(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Paint._setTextScaleX5433, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setTextScaleX5433, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.Typeface Typeface
		{
			get
			{
				return getTypeface();
			}
			set
			{
				setTypeface(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTypeface5434;
		public virtual global::android.graphics.Typeface getTypeface()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Paint._getTypeface5434)) as android.graphics.Typeface;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getTypeface5434)) as android.graphics.Typeface;
		}
		internal static global::MonoJavaBridge.MethodId _setShadowLayer5435;
		public virtual void setShadowLayer(float arg0, float arg1, float arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Paint._setShadowLayer5435, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setShadowLayer5435, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
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
		internal static global::MonoJavaBridge.MethodId _getAlpha5436;
		public virtual int getAlpha()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Paint._getAlpha5436);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getAlpha5436);
		}
		internal static global::MonoJavaBridge.MethodId _isAntiAlias5437;
		public virtual bool isAntiAlias()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Paint._isAntiAlias5437);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._isAntiAlias5437);
		}
		public new bool AntiAlias
		{
			set
			{
				setAntiAlias(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setAntiAlias5438;
		public virtual void setAntiAlias(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Paint._setAntiAlias5438, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setAntiAlias5438, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDither5439;
		public virtual bool isDither()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Paint._isDither5439);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._isDither5439);
		}
		internal static global::MonoJavaBridge.MethodId _isLinearText5440;
		public virtual bool isLinearText()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Paint._isLinearText5440);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._isLinearText5440);
		}
		public new bool LinearText
		{
			set
			{
				setLinearText(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setLinearText5441;
		public virtual void setLinearText(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Paint._setLinearText5441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setLinearText5441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSubpixelText5442;
		public virtual bool isSubpixelText()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Paint._isSubpixelText5442);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._isSubpixelText5442);
		}
		public new bool SubpixelText
		{
			set
			{
				setSubpixelText(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setSubpixelText5443;
		public virtual void setSubpixelText(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Paint._setSubpixelText5443, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setSubpixelText5443, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isUnderlineText5444;
		public virtual bool isUnderlineText()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Paint._isUnderlineText5444);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._isUnderlineText5444);
		}
		public new bool UnderlineText
		{
			set
			{
				setUnderlineText(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setUnderlineText5445;
		public virtual void setUnderlineText(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Paint._setUnderlineText5445, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setUnderlineText5445, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isStrikeThruText5446;
		public virtual bool isStrikeThruText()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Paint._isStrikeThruText5446);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._isStrikeThruText5446);
		}
		public new bool StrikeThruText
		{
			set
			{
				setStrikeThruText(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setStrikeThruText5447;
		public virtual void setStrikeThruText(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Paint._setStrikeThruText5447, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setStrikeThruText5447, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isFakeBoldText5448;
		public virtual bool isFakeBoldText()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Paint._isFakeBoldText5448);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._isFakeBoldText5448);
		}
		public new bool FakeBoldText
		{
			set
			{
				setFakeBoldText(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setFakeBoldText5449;
		public virtual void setFakeBoldText(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Paint._setFakeBoldText5449, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setFakeBoldText5449, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isFilterBitmap5450;
		public virtual bool isFilterBitmap()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Paint._isFilterBitmap5450);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._isFilterBitmap5450);
		}
		internal static global::MonoJavaBridge.MethodId _getStyle5451;
		public virtual global::android.graphics.Paint.Style getStyle()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Paint.Style>(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Paint._getStyle5451)) as android.graphics.Paint.Style;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Paint.Style>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getStyle5451)) as android.graphics.Paint.Style;
		}
		internal static global::MonoJavaBridge.MethodId _setStyle5452;
		public virtual void setStyle(android.graphics.Paint.Style arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Paint._setStyle5452, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setStyle5452, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setColor5453;
		public virtual void setColor(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Paint._setColor5453, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setColor5453, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setARGB5454;
		public virtual void setARGB(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Paint._setARGB5454, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setARGB5454, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
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
		internal static global::MonoJavaBridge.MethodId _getStrokeWidth5455;
		public virtual float getStrokeWidth()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.graphics.Paint._getStrokeWidth5455);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getStrokeWidth5455);
		}
		internal static global::MonoJavaBridge.MethodId _setStrokeWidth5456;
		public virtual void setStrokeWidth(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Paint._setStrokeWidth5456, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setStrokeWidth5456, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getStrokeMiter5457;
		public virtual float getStrokeMiter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.graphics.Paint._getStrokeMiter5457);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getStrokeMiter5457);
		}
		internal static global::MonoJavaBridge.MethodId _setStrokeMiter5458;
		public virtual void setStrokeMiter(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Paint._setStrokeMiter5458, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setStrokeMiter5458, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getStrokeCap5459;
		public virtual global::android.graphics.Paint.Cap getStrokeCap()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Paint.Cap>(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Paint._getStrokeCap5459)) as android.graphics.Paint.Cap;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Paint.Cap>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getStrokeCap5459)) as android.graphics.Paint.Cap;
		}
		internal static global::MonoJavaBridge.MethodId _setStrokeCap5460;
		public virtual void setStrokeCap(android.graphics.Paint.Cap arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Paint._setStrokeCap5460, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setStrokeCap5460, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getStrokeJoin5461;
		public virtual global::android.graphics.Paint.Join getStrokeJoin()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Paint.Join>(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Paint._getStrokeJoin5461)) as android.graphics.Paint.Join;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Paint.Join>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getStrokeJoin5461)) as android.graphics.Paint.Join;
		}
		internal static global::MonoJavaBridge.MethodId _setStrokeJoin5462;
		public virtual void setStrokeJoin(android.graphics.Paint.Join arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Paint._setStrokeJoin5462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setStrokeJoin5462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFillPath5463;
		public virtual bool getFillPath(android.graphics.Path arg0, android.graphics.Path arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Paint._getFillPath5463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getFillPath5463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::android.graphics.Shader Shader
		{
			get
			{
				return getShader();
			}
			set
			{
				setShader(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getShader5464;
		public virtual global::android.graphics.Shader getShader()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Paint._getShader5464)) as android.graphics.Shader;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getShader5464)) as android.graphics.Shader;
		}
		internal static global::MonoJavaBridge.MethodId _setShader5465;
		public virtual global::android.graphics.Shader setShader(android.graphics.Shader arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Paint._setShader5465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Shader;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setShader5465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Shader;
		}
		public new global::android.graphics.ColorFilter ColorFilter
		{
			get
			{
				return getColorFilter();
			}
			set
			{
				setColorFilter(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getColorFilter5466;
		public virtual global::android.graphics.ColorFilter getColorFilter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Paint._getColorFilter5466)) as android.graphics.ColorFilter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getColorFilter5466)) as android.graphics.ColorFilter;
		}
		public new global::android.graphics.Xfermode Xfermode
		{
			get
			{
				return getXfermode();
			}
			set
			{
				setXfermode(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getXfermode5467;
		public virtual global::android.graphics.Xfermode getXfermode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Paint._getXfermode5467)) as android.graphics.Xfermode;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getXfermode5467)) as android.graphics.Xfermode;
		}
		internal static global::MonoJavaBridge.MethodId _setXfermode5468;
		public virtual global::android.graphics.Xfermode setXfermode(android.graphics.Xfermode arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Paint._setXfermode5468, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Xfermode;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setXfermode5468, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Xfermode;
		}
		public new global::android.graphics.PathEffect PathEffect
		{
			get
			{
				return getPathEffect();
			}
			set
			{
				setPathEffect(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPathEffect5469;
		public virtual global::android.graphics.PathEffect getPathEffect()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Paint._getPathEffect5469)) as android.graphics.PathEffect;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getPathEffect5469)) as android.graphics.PathEffect;
		}
		internal static global::MonoJavaBridge.MethodId _setPathEffect5470;
		public virtual global::android.graphics.PathEffect setPathEffect(android.graphics.PathEffect arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Paint._setPathEffect5470, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.PathEffect;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setPathEffect5470, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.PathEffect;
		}
		public new global::android.graphics.MaskFilter MaskFilter
		{
			get
			{
				return getMaskFilter();
			}
			set
			{
				setMaskFilter(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMaskFilter5471;
		public virtual global::android.graphics.MaskFilter getMaskFilter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Paint._getMaskFilter5471)) as android.graphics.MaskFilter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getMaskFilter5471)) as android.graphics.MaskFilter;
		}
		internal static global::MonoJavaBridge.MethodId _setMaskFilter5472;
		public virtual global::android.graphics.MaskFilter setMaskFilter(android.graphics.MaskFilter arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Paint._setMaskFilter5472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.MaskFilter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setMaskFilter5472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.MaskFilter;
		}
		public new global::android.graphics.Rasterizer Rasterizer
		{
			get
			{
				return getRasterizer();
			}
			set
			{
				setRasterizer(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRasterizer5473;
		public virtual global::android.graphics.Rasterizer getRasterizer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Paint._getRasterizer5473)) as android.graphics.Rasterizer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getRasterizer5473)) as android.graphics.Rasterizer;
		}
		internal static global::MonoJavaBridge.MethodId _setRasterizer5474;
		public virtual global::android.graphics.Rasterizer setRasterizer(android.graphics.Rasterizer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Paint._setRasterizer5474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Rasterizer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setRasterizer5474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Rasterizer;
		}
		internal static global::MonoJavaBridge.MethodId _clearShadowLayer5475;
		public virtual void clearShadowLayer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Paint._clearShadowLayer5475);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._clearShadowLayer5475);
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
		internal static global::MonoJavaBridge.MethodId _getTextAlign5476;
		public virtual global::android.graphics.Paint.Align getTextAlign()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Paint.Align>(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Paint._getTextAlign5476)) as android.graphics.Paint.Align;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Paint.Align>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getTextAlign5476)) as android.graphics.Paint.Align;
		}
		internal static global::MonoJavaBridge.MethodId _setTextAlign5477;
		public virtual void setTextAlign(android.graphics.Paint.Align arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Paint._setTextAlign5477, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setTextAlign5477, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getTextSkewX5478;
		public virtual float getTextSkewX()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.graphics.Paint._getTextSkewX5478);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getTextSkewX5478);
		}
		internal static global::MonoJavaBridge.MethodId _setTextSkewX5479;
		public virtual void setTextSkewX(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Paint._setTextSkewX5479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._setTextSkewX5479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ascent5480;
		public virtual float ascent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.graphics.Paint._ascent5480);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._ascent5480);
		}
		internal static global::MonoJavaBridge.MethodId _descent5481;
		public virtual float descent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.graphics.Paint._descent5481);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._descent5481);
		}
		internal static global::MonoJavaBridge.MethodId _getFontMetrics5482;
		public virtual global::android.graphics.Paint.FontMetrics getFontMetrics()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Paint._getFontMetrics5482)) as android.graphics.Paint.FontMetrics;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getFontMetrics5482)) as android.graphics.Paint.FontMetrics;
		}
		internal static global::MonoJavaBridge.MethodId _getFontMetrics5483;
		public virtual float getFontMetrics(android.graphics.Paint.FontMetrics arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.graphics.Paint._getFontMetrics5483, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getFontMetrics5483, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFontMetricsInt5484;
		public virtual global::android.graphics.Paint.FontMetricsInt getFontMetricsInt()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Paint._getFontMetricsInt5484)) as android.graphics.Paint.FontMetricsInt;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getFontMetricsInt5484)) as android.graphics.Paint.FontMetricsInt;
		}
		internal static global::MonoJavaBridge.MethodId _getFontMetricsInt5485;
		public virtual int getFontMetricsInt(android.graphics.Paint.FontMetricsInt arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Paint._getFontMetricsInt5485, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getFontMetricsInt5485, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new float FontSpacing
		{
			get
			{
				return getFontSpacing();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFontSpacing5486;
		public virtual float getFontSpacing()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.graphics.Paint._getFontSpacing5486);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getFontSpacing5486);
		}
		internal static global::MonoJavaBridge.MethodId _measureText5487;
		public virtual float measureText(java.lang.String arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.graphics.Paint._measureText5487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._measureText5487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _measureText5488;
		public virtual float measureText(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.graphics.Paint._measureText5488, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._measureText5488, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _measureText5489;
		public virtual float measureText(java.lang.CharSequence arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.graphics.Paint._measureText5489, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._measureText5489, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public float measureText(string arg0, int arg1, int arg2)
		{
			return measureText((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		internal static global::MonoJavaBridge.MethodId _measureText5490;
		public virtual float measureText(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.graphics.Paint._measureText5490, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._measureText5490, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _breakText5491;
		public virtual int breakText(java.lang.CharSequence arg0, int arg1, int arg2, bool arg3, float arg4, float[] arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Paint._breakText5491, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._breakText5491, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		public int breakText(string arg0, int arg1, int arg2, bool arg3, float arg4, float[] arg5)
		{
			return breakText((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3, arg4, arg5);
		}
		internal static global::MonoJavaBridge.MethodId _breakText5492;
		public virtual int breakText(java.lang.String arg0, bool arg1, float arg2, float[] arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Paint._breakText5492, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._breakText5492, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _breakText5493;
		public virtual int breakText(char[] arg0, int arg1, int arg2, float arg3, float[] arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Paint._breakText5493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._breakText5493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _getTextWidths5494;
		public virtual int getTextWidths(java.lang.CharSequence arg0, int arg1, int arg2, float[] arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Paint._getTextWidths5494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getTextWidths5494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public int getTextWidths(string arg0, int arg1, int arg2, float[] arg3)
		{
			return getTextWidths((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3);
		}
		internal static global::MonoJavaBridge.MethodId _getTextWidths5495;
		public virtual int getTextWidths(java.lang.String arg0, int arg1, int arg2, float[] arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Paint._getTextWidths5495, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getTextWidths5495, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _getTextWidths5496;
		public virtual int getTextWidths(java.lang.String arg0, float[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Paint._getTextWidths5496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getTextWidths5496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getTextWidths5497;
		public virtual int getTextWidths(char[] arg0, int arg1, int arg2, float[] arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Paint._getTextWidths5497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getTextWidths5497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _getTextPath5498;
		public virtual void getTextPath(java.lang.String arg0, int arg1, int arg2, float arg3, float arg4, android.graphics.Path arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Paint._getTextPath5498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getTextPath5498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _getTextPath5499;
		public virtual void getTextPath(char[] arg0, int arg1, int arg2, float arg3, float arg4, android.graphics.Path arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Paint._getTextPath5499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getTextPath5499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _getTextBounds5500;
		public virtual void getTextBounds(java.lang.String arg0, int arg1, int arg2, android.graphics.Rect arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Paint._getTextBounds5500, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getTextBounds5500, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _getTextBounds5501;
		public virtual void getTextBounds(char[] arg0, int arg1, int arg2, android.graphics.Rect arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Paint._getTextBounds5501, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Paint.staticClass, global::android.graphics.Paint._getTextBounds5501, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _Paint5502;
		public Paint() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Paint.staticClass, global::android.graphics.Paint._Paint5502);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Paint5503;
		public Paint(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Paint.staticClass, global::android.graphics.Paint._Paint5503, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Paint5504;
		public Paint(android.graphics.Paint arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Paint.staticClass, global::android.graphics.Paint._Paint5504, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		static Paint()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.Paint.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Paint"));
			global::android.graphics.Paint._finalize5419 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "finalize", "()V");
			global::android.graphics.Paint._set5420 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "set", "(Landroid/graphics/Paint;)V");
			global::android.graphics.Paint._reset5421 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "reset", "()V");
			global::android.graphics.Paint._getFlags5422 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "getFlags", "()I");
			global::android.graphics.Paint._setFlags5423 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "setFlags", "(I)V");
			global::android.graphics.Paint._getColor5424 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "getColor", "()I");
			global::android.graphics.Paint._setDither5425 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "setDither", "(Z)V");
			global::android.graphics.Paint._setFilterBitmap5426 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "setFilterBitmap", "(Z)V");
			global::android.graphics.Paint._setAlpha5427 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "setAlpha", "(I)V");
			global::android.graphics.Paint._setColorFilter5428 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)Landroid/graphics/ColorFilter;");
			global::android.graphics.Paint._setTypeface5429 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "setTypeface", "(Landroid/graphics/Typeface;)Landroid/graphics/Typeface;");
			global::android.graphics.Paint._getTextSize5430 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "getTextSize", "()F");
			global::android.graphics.Paint._setTextSize5431 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "setTextSize", "(F)V");
			global::android.graphics.Paint._getTextScaleX5432 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "getTextScaleX", "()F");
			global::android.graphics.Paint._setTextScaleX5433 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "setTextScaleX", "(F)V");
			global::android.graphics.Paint._getTypeface5434 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "getTypeface", "()Landroid/graphics/Typeface;");
			global::android.graphics.Paint._setShadowLayer5435 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "setShadowLayer", "(FFFI)V");
			global::android.graphics.Paint._getAlpha5436 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "getAlpha", "()I");
			global::android.graphics.Paint._isAntiAlias5437 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "isAntiAlias", "()Z");
			global::android.graphics.Paint._setAntiAlias5438 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "setAntiAlias", "(Z)V");
			global::android.graphics.Paint._isDither5439 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "isDither", "()Z");
			global::android.graphics.Paint._isLinearText5440 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "isLinearText", "()Z");
			global::android.graphics.Paint._setLinearText5441 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "setLinearText", "(Z)V");
			global::android.graphics.Paint._isSubpixelText5442 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "isSubpixelText", "()Z");
			global::android.graphics.Paint._setSubpixelText5443 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "setSubpixelText", "(Z)V");
			global::android.graphics.Paint._isUnderlineText5444 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "isUnderlineText", "()Z");
			global::android.graphics.Paint._setUnderlineText5445 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "setUnderlineText", "(Z)V");
			global::android.graphics.Paint._isStrikeThruText5446 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "isStrikeThruText", "()Z");
			global::android.graphics.Paint._setStrikeThruText5447 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "setStrikeThruText", "(Z)V");
			global::android.graphics.Paint._isFakeBoldText5448 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "isFakeBoldText", "()Z");
			global::android.graphics.Paint._setFakeBoldText5449 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "setFakeBoldText", "(Z)V");
			global::android.graphics.Paint._isFilterBitmap5450 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "isFilterBitmap", "()Z");
			global::android.graphics.Paint._getStyle5451 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "getStyle", "()Landroid/graphics/Paint$Style;");
			global::android.graphics.Paint._setStyle5452 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "setStyle", "(Landroid/graphics/Paint$Style;)V");
			global::android.graphics.Paint._setColor5453 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "setColor", "(I)V");
			global::android.graphics.Paint._setARGB5454 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "setARGB", "(IIII)V");
			global::android.graphics.Paint._getStrokeWidth5455 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "getStrokeWidth", "()F");
			global::android.graphics.Paint._setStrokeWidth5456 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "setStrokeWidth", "(F)V");
			global::android.graphics.Paint._getStrokeMiter5457 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "getStrokeMiter", "()F");
			global::android.graphics.Paint._setStrokeMiter5458 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "setStrokeMiter", "(F)V");
			global::android.graphics.Paint._getStrokeCap5459 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "getStrokeCap", "()Landroid/graphics/Paint$Cap;");
			global::android.graphics.Paint._setStrokeCap5460 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "setStrokeCap", "(Landroid/graphics/Paint$Cap;)V");
			global::android.graphics.Paint._getStrokeJoin5461 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "getStrokeJoin", "()Landroid/graphics/Paint$Join;");
			global::android.graphics.Paint._setStrokeJoin5462 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "setStrokeJoin", "(Landroid/graphics/Paint$Join;)V");
			global::android.graphics.Paint._getFillPath5463 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "getFillPath", "(Landroid/graphics/Path;Landroid/graphics/Path;)Z");
			global::android.graphics.Paint._getShader5464 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "getShader", "()Landroid/graphics/Shader;");
			global::android.graphics.Paint._setShader5465 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "setShader", "(Landroid/graphics/Shader;)Landroid/graphics/Shader;");
			global::android.graphics.Paint._getColorFilter5466 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "getColorFilter", "()Landroid/graphics/ColorFilter;");
			global::android.graphics.Paint._getXfermode5467 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "getXfermode", "()Landroid/graphics/Xfermode;");
			global::android.graphics.Paint._setXfermode5468 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "setXfermode", "(Landroid/graphics/Xfermode;)Landroid/graphics/Xfermode;");
			global::android.graphics.Paint._getPathEffect5469 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "getPathEffect", "()Landroid/graphics/PathEffect;");
			global::android.graphics.Paint._setPathEffect5470 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "setPathEffect", "(Landroid/graphics/PathEffect;)Landroid/graphics/PathEffect;");
			global::android.graphics.Paint._getMaskFilter5471 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "getMaskFilter", "()Landroid/graphics/MaskFilter;");
			global::android.graphics.Paint._setMaskFilter5472 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "setMaskFilter", "(Landroid/graphics/MaskFilter;)Landroid/graphics/MaskFilter;");
			global::android.graphics.Paint._getRasterizer5473 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "getRasterizer", "()Landroid/graphics/Rasterizer;");
			global::android.graphics.Paint._setRasterizer5474 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "setRasterizer", "(Landroid/graphics/Rasterizer;)Landroid/graphics/Rasterizer;");
			global::android.graphics.Paint._clearShadowLayer5475 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "clearShadowLayer", "()V");
			global::android.graphics.Paint._getTextAlign5476 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "getTextAlign", "()Landroid/graphics/Paint$Align;");
			global::android.graphics.Paint._setTextAlign5477 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "setTextAlign", "(Landroid/graphics/Paint$Align;)V");
			global::android.graphics.Paint._getTextSkewX5478 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "getTextSkewX", "()F");
			global::android.graphics.Paint._setTextSkewX5479 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "setTextSkewX", "(F)V");
			global::android.graphics.Paint._ascent5480 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "ascent", "()F");
			global::android.graphics.Paint._descent5481 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "descent", "()F");
			global::android.graphics.Paint._getFontMetrics5482 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "getFontMetrics", "()Landroid/graphics/Paint$FontMetrics;");
			global::android.graphics.Paint._getFontMetrics5483 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "getFontMetrics", "(Landroid/graphics/Paint$FontMetrics;)F");
			global::android.graphics.Paint._getFontMetricsInt5484 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "getFontMetricsInt", "()Landroid/graphics/Paint$FontMetricsInt;");
			global::android.graphics.Paint._getFontMetricsInt5485 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "getFontMetricsInt", "(Landroid/graphics/Paint$FontMetricsInt;)I");
			global::android.graphics.Paint._getFontSpacing5486 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "getFontSpacing", "()F");
			global::android.graphics.Paint._measureText5487 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "measureText", "(Ljava/lang/String;II)F");
			global::android.graphics.Paint._measureText5488 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "measureText", "(Ljava/lang/String;)F");
			global::android.graphics.Paint._measureText5489 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "measureText", "(Ljava/lang/CharSequence;II)F");
			global::android.graphics.Paint._measureText5490 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "measureText", "([CII)F");
			global::android.graphics.Paint._breakText5491 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "breakText", "(Ljava/lang/CharSequence;IIZF[F)I");
			global::android.graphics.Paint._breakText5492 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "breakText", "(Ljava/lang/String;ZF[F)I");
			global::android.graphics.Paint._breakText5493 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "breakText", "([CIIF[F)I");
			global::android.graphics.Paint._getTextWidths5494 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "getTextWidths", "(Ljava/lang/CharSequence;II[F)I");
			global::android.graphics.Paint._getTextWidths5495 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "getTextWidths", "(Ljava/lang/String;II[F)I");
			global::android.graphics.Paint._getTextWidths5496 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "getTextWidths", "(Ljava/lang/String;[F)I");
			global::android.graphics.Paint._getTextWidths5497 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "getTextWidths", "([CII[F)I");
			global::android.graphics.Paint._getTextPath5498 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "getTextPath", "(Ljava/lang/String;IIFFLandroid/graphics/Path;)V");
			global::android.graphics.Paint._getTextPath5499 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "getTextPath", "([CIIFFLandroid/graphics/Path;)V");
			global::android.graphics.Paint._getTextBounds5500 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "getTextBounds", "(Ljava/lang/String;IILandroid/graphics/Rect;)V");
			global::android.graphics.Paint._getTextBounds5501 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "getTextBounds", "([CIILandroid/graphics/Rect;)V");
			global::android.graphics.Paint._Paint5502 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "<init>", "()V");
			global::android.graphics.Paint._Paint5503 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "<init>", "(I)V");
			global::android.graphics.Paint._Paint5504 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "<init>", "(Landroid/graphics/Paint;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
