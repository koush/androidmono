namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Path : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Path(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Direction : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal Direction(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values5515;
			public static global::android.graphics.Path.Direction[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.Path.Direction>(@__env.CallStaticObjectMethod(android.graphics.Path.Direction.staticClass, global::android.graphics.Path.Direction._values5515)) as android.graphics.Path.Direction[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf5516;
			public static global::android.graphics.Path.Direction valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Path.Direction>(@__env.CallStaticObjectMethod(android.graphics.Path.Direction.staticClass, global::android.graphics.Path.Direction._valueOf5516, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Path.Direction;
			}
			internal static global::MonoJavaBridge.FieldId _CCW5517;
			public static global::android.graphics.Path.Direction CCW
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Path.Direction>(@__env.GetStaticObjectField(global::android.graphics.Path.Direction.staticClass, _CCW5517)) as android.graphics.Path.Direction;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CW5518;
			public static global::android.graphics.Path.Direction CW
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Path.Direction>(@__env.GetStaticObjectField(global::android.graphics.Path.Direction.staticClass, _CW5518)) as android.graphics.Path.Direction;
				}
			}
			static Direction()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.Path.Direction.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Path$Direction"));
				global::android.graphics.Path.Direction._values5515 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Path.Direction.staticClass, "values", "()[Landroid/graphics/Path/Direction;");
				global::android.graphics.Path.Direction._valueOf5516 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Path.Direction.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Path$Direction;");
				global::android.graphics.Path.Direction._CCW5517 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Path.Direction.staticClass, "CCW", "Landroid/graphics/Path$Direction;");
				global::android.graphics.Path.Direction._CW5518 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Path.Direction.staticClass, "CW", "Landroid/graphics/Path$Direction;");
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class FillType : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal FillType(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values5519;
			public static global::android.graphics.Path.FillType[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.Path.FillType>(@__env.CallStaticObjectMethod(android.graphics.Path.FillType.staticClass, global::android.graphics.Path.FillType._values5519)) as android.graphics.Path.FillType[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf5520;
			public static global::android.graphics.Path.FillType valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Path.FillType>(@__env.CallStaticObjectMethod(android.graphics.Path.FillType.staticClass, global::android.graphics.Path.FillType._valueOf5520, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Path.FillType;
			}
			internal static global::MonoJavaBridge.FieldId _EVEN_ODD5521;
			public static global::android.graphics.Path.FillType EVEN_ODD
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Path.FillType>(@__env.GetStaticObjectField(global::android.graphics.Path.FillType.staticClass, _EVEN_ODD5521)) as android.graphics.Path.FillType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _INVERSE_EVEN_ODD5522;
			public static global::android.graphics.Path.FillType INVERSE_EVEN_ODD
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Path.FillType>(@__env.GetStaticObjectField(global::android.graphics.Path.FillType.staticClass, _INVERSE_EVEN_ODD5522)) as android.graphics.Path.FillType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _INVERSE_WINDING5523;
			public static global::android.graphics.Path.FillType INVERSE_WINDING
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Path.FillType>(@__env.GetStaticObjectField(global::android.graphics.Path.FillType.staticClass, _INVERSE_WINDING5523)) as android.graphics.Path.FillType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _WINDING5524;
			public static global::android.graphics.Path.FillType WINDING
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Path.FillType>(@__env.GetStaticObjectField(global::android.graphics.Path.FillType.staticClass, _WINDING5524)) as android.graphics.Path.FillType;
				}
			}
			static FillType()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.Path.FillType.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Path$FillType"));
				global::android.graphics.Path.FillType._values5519 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Path.FillType.staticClass, "values", "()[Landroid/graphics/Path/FillType;");
				global::android.graphics.Path.FillType._valueOf5520 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Path.FillType.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Path$FillType;");
				global::android.graphics.Path.FillType._EVEN_ODD5521 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Path.FillType.staticClass, "EVEN_ODD", "Landroid/graphics/Path$FillType;");
				global::android.graphics.Path.FillType._INVERSE_EVEN_ODD5522 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Path.FillType.staticClass, "INVERSE_EVEN_ODD", "Landroid/graphics/Path$FillType;");
				global::android.graphics.Path.FillType._INVERSE_WINDING5523 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Path.FillType.staticClass, "INVERSE_WINDING", "Landroid/graphics/Path$FillType;");
				global::android.graphics.Path.FillType._WINDING5524 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Path.FillType.staticClass, "WINDING", "Landroid/graphics/Path$FillType;");
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _finalize5525;
		protected override void finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._finalize5525);
		}
		internal static global::MonoJavaBridge.MethodId _offset5526;
		public virtual void offset(float arg0, float arg1, android.graphics.Path arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._offset5526, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _offset5527;
		public virtual void offset(float arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._offset5527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty5528;
		public virtual bool isEmpty()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._isEmpty5528);
		}
		internal static global::MonoJavaBridge.MethodId _transform5529;
		public virtual void transform(android.graphics.Matrix arg0, android.graphics.Path arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._transform5529, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _transform5530;
		public virtual void transform(android.graphics.Matrix arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._transform5530, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _close5531;
		public virtual void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._close5531);
		}
		internal static global::MonoJavaBridge.MethodId _set5532;
		public virtual void set(android.graphics.Path arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._set5532, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reset5533;
		public virtual void reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._reset5533);
		}
		internal static global::MonoJavaBridge.MethodId _rewind5534;
		public virtual void rewind()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._rewind5534);
		}
		internal static global::MonoJavaBridge.MethodId _isRect5535;
		public virtual bool isRect(android.graphics.RectF arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._isRect5535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFillType5536;
		public virtual global::android.graphics.Path.FillType getFillType()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Path.FillType>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._getFillType5536)) as android.graphics.Path.FillType;
		}
		internal static global::MonoJavaBridge.MethodId _setFillType5537;
		public virtual void setFillType(android.graphics.Path.FillType arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._setFillType5537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isInverseFillType5538;
		public virtual bool isInverseFillType()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._isInverseFillType5538);
		}
		internal static global::MonoJavaBridge.MethodId _toggleInverseFillType5539;
		public virtual void toggleInverseFillType()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._toggleInverseFillType5539);
		}
		internal static global::MonoJavaBridge.MethodId _computeBounds5540;
		public virtual void computeBounds(android.graphics.RectF arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._computeBounds5540, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _incReserve5541;
		public virtual void incReserve(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._incReserve5541, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _moveTo5542;
		public virtual void moveTo(float arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._moveTo5542, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _rMoveTo5543;
		public virtual void rMoveTo(float arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._rMoveTo5543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _lineTo5544;
		public virtual void lineTo(float arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._lineTo5544, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _rLineTo5545;
		public virtual void rLineTo(float arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._rLineTo5545, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _quadTo5546;
		public virtual void quadTo(float arg0, float arg1, float arg2, float arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._quadTo5546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _rQuadTo5547;
		public virtual void rQuadTo(float arg0, float arg1, float arg2, float arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._rQuadTo5547, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _cubicTo5548;
		public virtual void cubicTo(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._cubicTo5548, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _rCubicTo5549;
		public virtual void rCubicTo(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._rCubicTo5549, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _arcTo5550;
		public virtual void arcTo(android.graphics.RectF arg0, float arg1, float arg2, bool arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._arcTo5550, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _arcTo5551;
		public virtual void arcTo(android.graphics.RectF arg0, float arg1, float arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._arcTo5551, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _addRect5552;
		public virtual void addRect(float arg0, float arg1, float arg2, float arg3, android.graphics.Path.Direction arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._addRect5552, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _addRect5553;
		public virtual void addRect(android.graphics.RectF arg0, android.graphics.Path.Direction arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._addRect5553, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addOval5554;
		public virtual void addOval(android.graphics.RectF arg0, android.graphics.Path.Direction arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._addOval5554, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addCircle5555;
		public virtual void addCircle(float arg0, float arg1, float arg2, android.graphics.Path.Direction arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._addCircle5555, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _addArc5556;
		public virtual void addArc(android.graphics.RectF arg0, float arg1, float arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._addArc5556, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _addRoundRect5557;
		public virtual void addRoundRect(android.graphics.RectF arg0, float arg1, float arg2, android.graphics.Path.Direction arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._addRoundRect5557, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _addRoundRect5558;
		public virtual void addRoundRect(android.graphics.RectF arg0, float[] arg1, android.graphics.Path.Direction arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._addRoundRect5558, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _addPath5559;
		public virtual void addPath(android.graphics.Path arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._addPath5559, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addPath5560;
		public virtual void addPath(android.graphics.Path arg0, android.graphics.Matrix arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._addPath5560, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addPath5561;
		public virtual void addPath(android.graphics.Path arg0, float arg1, float arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._addPath5561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setLastPoint5562;
		public virtual void setLastPoint(float arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._setLastPoint5562, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _Path5563;
		public Path() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Path.staticClass, global::android.graphics.Path._Path5563);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Path5564;
		public Path(android.graphics.Path arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Path.staticClass, global::android.graphics.Path._Path5564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static Path()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.Path.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Path"));
			global::android.graphics.Path._finalize5525 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "finalize", "()V");
			global::android.graphics.Path._offset5526 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "offset", "(FFLandroid/graphics/Path;)V");
			global::android.graphics.Path._offset5527 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "offset", "(FF)V");
			global::android.graphics.Path._isEmpty5528 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "isEmpty", "()Z");
			global::android.graphics.Path._transform5529 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "transform", "(Landroid/graphics/Matrix;Landroid/graphics/Path;)V");
			global::android.graphics.Path._transform5530 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "transform", "(Landroid/graphics/Matrix;)V");
			global::android.graphics.Path._close5531 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "close", "()V");
			global::android.graphics.Path._set5532 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "set", "(Landroid/graphics/Path;)V");
			global::android.graphics.Path._reset5533 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "reset", "()V");
			global::android.graphics.Path._rewind5534 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "rewind", "()V");
			global::android.graphics.Path._isRect5535 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "isRect", "(Landroid/graphics/RectF;)Z");
			global::android.graphics.Path._getFillType5536 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "getFillType", "()Landroid/graphics/Path$FillType;");
			global::android.graphics.Path._setFillType5537 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "setFillType", "(Landroid/graphics/Path$FillType;)V");
			global::android.graphics.Path._isInverseFillType5538 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "isInverseFillType", "()Z");
			global::android.graphics.Path._toggleInverseFillType5539 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "toggleInverseFillType", "()V");
			global::android.graphics.Path._computeBounds5540 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "computeBounds", "(Landroid/graphics/RectF;Z)V");
			global::android.graphics.Path._incReserve5541 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "incReserve", "(I)V");
			global::android.graphics.Path._moveTo5542 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "moveTo", "(FF)V");
			global::android.graphics.Path._rMoveTo5543 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "rMoveTo", "(FF)V");
			global::android.graphics.Path._lineTo5544 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "lineTo", "(FF)V");
			global::android.graphics.Path._rLineTo5545 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "rLineTo", "(FF)V");
			global::android.graphics.Path._quadTo5546 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "quadTo", "(FFFF)V");
			global::android.graphics.Path._rQuadTo5547 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "rQuadTo", "(FFFF)V");
			global::android.graphics.Path._cubicTo5548 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "cubicTo", "(FFFFFF)V");
			global::android.graphics.Path._rCubicTo5549 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "rCubicTo", "(FFFFFF)V");
			global::android.graphics.Path._arcTo5550 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "arcTo", "(Landroid/graphics/RectF;FFZ)V");
			global::android.graphics.Path._arcTo5551 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "arcTo", "(Landroid/graphics/RectF;FF)V");
			global::android.graphics.Path._addRect5552 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "addRect", "(FFFFLandroid/graphics/Path$Direction;)V");
			global::android.graphics.Path._addRect5553 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "addRect", "(Landroid/graphics/RectF;Landroid/graphics/Path$Direction;)V");
			global::android.graphics.Path._addOval5554 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "addOval", "(Landroid/graphics/RectF;Landroid/graphics/Path$Direction;)V");
			global::android.graphics.Path._addCircle5555 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "addCircle", "(FFFLandroid/graphics/Path$Direction;)V");
			global::android.graphics.Path._addArc5556 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "addArc", "(Landroid/graphics/RectF;FF)V");
			global::android.graphics.Path._addRoundRect5557 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "addRoundRect", "(Landroid/graphics/RectF;FFLandroid/graphics/Path$Direction;)V");
			global::android.graphics.Path._addRoundRect5558 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "addRoundRect", "(Landroid/graphics/RectF;[FLandroid/graphics/Path$Direction;)V");
			global::android.graphics.Path._addPath5559 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "addPath", "(Landroid/graphics/Path;)V");
			global::android.graphics.Path._addPath5560 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "addPath", "(Landroid/graphics/Path;Landroid/graphics/Matrix;)V");
			global::android.graphics.Path._addPath5561 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "addPath", "(Landroid/graphics/Path;FF)V");
			global::android.graphics.Path._setLastPoint5562 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "setLastPoint", "(FF)V");
			global::android.graphics.Path._Path5563 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "<init>", "()V");
			global::android.graphics.Path._Path5564 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "<init>", "(Landroid/graphics/Path;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
