namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Path : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Path()
		{
			InitJNI();
		}
		protected Path(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Direction : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Direction()
			{
				InitJNI();
			}
			internal Direction(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values3535;
			public static global::android.graphics.Path.Direction[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.Path.Direction>(@__env.CallStaticObjectMethod(android.graphics.Path.Direction.staticClass, global::android.graphics.Path.Direction._values3535)) as android.graphics.Path.Direction[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf3536;
			public static global::android.graphics.Path.Direction valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.Path.Direction.staticClass, global::android.graphics.Path.Direction._valueOf3536, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Path.Direction;
			}
			internal static global::MonoJavaBridge.FieldId _CCW3537;
			public static global::android.graphics.Path.Direction CCW
			{
				get
				{
					return default(global::android.graphics.Path.Direction);
				}
			}
			internal static global::MonoJavaBridge.FieldId _CW3538;
			public static global::android.graphics.Path.Direction CW
			{
				get
				{
					return default(global::android.graphics.Path.Direction);
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.Path.Direction.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Path$Direction"));
				global::android.graphics.Path.Direction._values3535 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Path.Direction.staticClass, "values", "()[Landroid/graphics/Path/Direction;");
				global::android.graphics.Path.Direction._valueOf3536 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Path.Direction.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Path$Direction;");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class FillType : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static FillType()
			{
				InitJNI();
			}
			internal FillType(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values3539;
			public static global::android.graphics.Path.FillType[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.Path.FillType>(@__env.CallStaticObjectMethod(android.graphics.Path.FillType.staticClass, global::android.graphics.Path.FillType._values3539)) as android.graphics.Path.FillType[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf3540;
			public static global::android.graphics.Path.FillType valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.Path.FillType.staticClass, global::android.graphics.Path.FillType._valueOf3540, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Path.FillType;
			}
			internal static global::MonoJavaBridge.FieldId _EVEN_ODD3541;
			public static global::android.graphics.Path.FillType EVEN_ODD
			{
				get
				{
					return default(global::android.graphics.Path.FillType);
				}
			}
			internal static global::MonoJavaBridge.FieldId _INVERSE_EVEN_ODD3542;
			public static global::android.graphics.Path.FillType INVERSE_EVEN_ODD
			{
				get
				{
					return default(global::android.graphics.Path.FillType);
				}
			}
			internal static global::MonoJavaBridge.FieldId _INVERSE_WINDING3543;
			public static global::android.graphics.Path.FillType INVERSE_WINDING
			{
				get
				{
					return default(global::android.graphics.Path.FillType);
				}
			}
			internal static global::MonoJavaBridge.FieldId _WINDING3544;
			public static global::android.graphics.Path.FillType WINDING
			{
				get
				{
					return default(global::android.graphics.Path.FillType);
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.Path.FillType.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Path$FillType"));
				global::android.graphics.Path.FillType._values3539 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Path.FillType.staticClass, "values", "()[Landroid/graphics/Path/FillType;");
				global::android.graphics.Path.FillType._valueOf3540 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Path.FillType.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Path$FillType;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _finalize3545;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Path._finalize3545);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._finalize3545);
		}
		internal static global::MonoJavaBridge.MethodId _offset3546;
		public virtual void offset(float arg0, float arg1, android.graphics.Path arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Path._offset3546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._offset3546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _offset3547;
		public virtual void offset(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Path._offset3547, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._offset3547, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty3548;
		public virtual bool isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Path._isEmpty3548);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._isEmpty3548);
		}
		internal static global::MonoJavaBridge.MethodId _transform3549;
		public virtual void transform(android.graphics.Matrix arg0, android.graphics.Path arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Path._transform3549, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._transform3549, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _transform3550;
		public virtual void transform(android.graphics.Matrix arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Path._transform3550, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._transform3550, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _close3551;
		public virtual void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Path._close3551);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._close3551);
		}
		internal static global::MonoJavaBridge.MethodId _set3552;
		public virtual void set(android.graphics.Path arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Path._set3552, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._set3552, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reset3553;
		public virtual void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Path._reset3553);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._reset3553);
		}
		internal static global::MonoJavaBridge.MethodId _rewind3554;
		public virtual void rewind() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Path._rewind3554);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._rewind3554);
		}
		internal static global::MonoJavaBridge.MethodId _isRect3555;
		public virtual bool isRect(android.graphics.RectF arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Path._isRect3555, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._isRect3555, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFillType3556;
		public virtual global::android.graphics.Path.FillType getFillType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Path._getFillType3556)) as android.graphics.Path.FillType;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._getFillType3556)) as android.graphics.Path.FillType;
		}
		internal static global::MonoJavaBridge.MethodId _setFillType3557;
		public virtual void setFillType(android.graphics.Path.FillType arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Path._setFillType3557, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._setFillType3557, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isInverseFillType3558;
		public virtual bool isInverseFillType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Path._isInverseFillType3558);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._isInverseFillType3558);
		}
		internal static global::MonoJavaBridge.MethodId _toggleInverseFillType3559;
		public virtual void toggleInverseFillType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Path._toggleInverseFillType3559);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._toggleInverseFillType3559);
		}
		internal static global::MonoJavaBridge.MethodId _computeBounds3560;
		public virtual void computeBounds(android.graphics.RectF arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Path._computeBounds3560, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._computeBounds3560, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _incReserve3561;
		public virtual void incReserve(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Path._incReserve3561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._incReserve3561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _moveTo3562;
		public virtual void moveTo(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Path._moveTo3562, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._moveTo3562, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _rMoveTo3563;
		public virtual void rMoveTo(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Path._rMoveTo3563, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._rMoveTo3563, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _lineTo3564;
		public virtual void lineTo(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Path._lineTo3564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._lineTo3564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _rLineTo3565;
		public virtual void rLineTo(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Path._rLineTo3565, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._rLineTo3565, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _quadTo3566;
		public virtual void quadTo(float arg0, float arg1, float arg2, float arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Path._quadTo3566, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._quadTo3566, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _rQuadTo3567;
		public virtual void rQuadTo(float arg0, float arg1, float arg2, float arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Path._rQuadTo3567, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._rQuadTo3567, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _cubicTo3568;
		public virtual void cubicTo(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Path._cubicTo3568, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._cubicTo3568, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _rCubicTo3569;
		public virtual void rCubicTo(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Path._rCubicTo3569, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._rCubicTo3569, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _arcTo3570;
		public virtual void arcTo(android.graphics.RectF arg0, float arg1, float arg2, bool arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Path._arcTo3570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._arcTo3570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _arcTo3571;
		public virtual void arcTo(android.graphics.RectF arg0, float arg1, float arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Path._arcTo3571, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._arcTo3571, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _addRect3572;
		public virtual void addRect(float arg0, float arg1, float arg2, float arg3, android.graphics.Path.Direction arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Path._addRect3572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._addRect3572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _addRect3573;
		public virtual void addRect(android.graphics.RectF arg0, android.graphics.Path.Direction arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Path._addRect3573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._addRect3573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addOval3574;
		public virtual void addOval(android.graphics.RectF arg0, android.graphics.Path.Direction arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Path._addOval3574, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._addOval3574, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addCircle3575;
		public virtual void addCircle(float arg0, float arg1, float arg2, android.graphics.Path.Direction arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Path._addCircle3575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._addCircle3575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _addArc3576;
		public virtual void addArc(android.graphics.RectF arg0, float arg1, float arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Path._addArc3576, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._addArc3576, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _addRoundRect3577;
		public virtual void addRoundRect(android.graphics.RectF arg0, float arg1, float arg2, android.graphics.Path.Direction arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Path._addRoundRect3577, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._addRoundRect3577, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _addRoundRect3578;
		public virtual void addRoundRect(android.graphics.RectF arg0, float[] arg1, android.graphics.Path.Direction arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Path._addRoundRect3578, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._addRoundRect3578, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _addPath3579;
		public virtual void addPath(android.graphics.Path arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Path._addPath3579, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._addPath3579, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addPath3580;
		public virtual void addPath(android.graphics.Path arg0, android.graphics.Matrix arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Path._addPath3580, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._addPath3580, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addPath3581;
		public virtual void addPath(android.graphics.Path arg0, float arg1, float arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Path._addPath3581, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._addPath3581, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setLastPoint3582;
		public virtual void setLastPoint(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Path._setLastPoint3582, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._setLastPoint3582, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _Path3583;
		public Path()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Path.staticClass, global::android.graphics.Path._Path3583);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Path3584;
		public Path(android.graphics.Path arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Path.staticClass, global::android.graphics.Path._Path3584, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.Path.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Path"));
			global::android.graphics.Path._finalize3545 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "finalize", "()V");
			global::android.graphics.Path._offset3546 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "offset", "(FFLandroid/graphics/Path;)V");
			global::android.graphics.Path._offset3547 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "offset", "(FF)V");
			global::android.graphics.Path._isEmpty3548 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "isEmpty", "()Z");
			global::android.graphics.Path._transform3549 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "transform", "(Landroid/graphics/Matrix;Landroid/graphics/Path;)V");
			global::android.graphics.Path._transform3550 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "transform", "(Landroid/graphics/Matrix;)V");
			global::android.graphics.Path._close3551 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "close", "()V");
			global::android.graphics.Path._set3552 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "set", "(Landroid/graphics/Path;)V");
			global::android.graphics.Path._reset3553 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "reset", "()V");
			global::android.graphics.Path._rewind3554 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "rewind", "()V");
			global::android.graphics.Path._isRect3555 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "isRect", "(Landroid/graphics/RectF;)Z");
			global::android.graphics.Path._getFillType3556 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "getFillType", "()Landroid/graphics/Path$FillType;");
			global::android.graphics.Path._setFillType3557 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "setFillType", "(Landroid/graphics/Path$FillType;)V");
			global::android.graphics.Path._isInverseFillType3558 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "isInverseFillType", "()Z");
			global::android.graphics.Path._toggleInverseFillType3559 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "toggleInverseFillType", "()V");
			global::android.graphics.Path._computeBounds3560 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "computeBounds", "(Landroid/graphics/RectF;Z)V");
			global::android.graphics.Path._incReserve3561 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "incReserve", "(I)V");
			global::android.graphics.Path._moveTo3562 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "moveTo", "(FF)V");
			global::android.graphics.Path._rMoveTo3563 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "rMoveTo", "(FF)V");
			global::android.graphics.Path._lineTo3564 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "lineTo", "(FF)V");
			global::android.graphics.Path._rLineTo3565 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "rLineTo", "(FF)V");
			global::android.graphics.Path._quadTo3566 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "quadTo", "(FFFF)V");
			global::android.graphics.Path._rQuadTo3567 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "rQuadTo", "(FFFF)V");
			global::android.graphics.Path._cubicTo3568 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "cubicTo", "(FFFFFF)V");
			global::android.graphics.Path._rCubicTo3569 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "rCubicTo", "(FFFFFF)V");
			global::android.graphics.Path._arcTo3570 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "arcTo", "(Landroid/graphics/RectF;FFZ)V");
			global::android.graphics.Path._arcTo3571 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "arcTo", "(Landroid/graphics/RectF;FF)V");
			global::android.graphics.Path._addRect3572 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "addRect", "(FFFFLandroid/graphics/Path$Direction;)V");
			global::android.graphics.Path._addRect3573 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "addRect", "(Landroid/graphics/RectF;Landroid/graphics/Path$Direction;)V");
			global::android.graphics.Path._addOval3574 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "addOval", "(Landroid/graphics/RectF;Landroid/graphics/Path$Direction;)V");
			global::android.graphics.Path._addCircle3575 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "addCircle", "(FFFLandroid/graphics/Path$Direction;)V");
			global::android.graphics.Path._addArc3576 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "addArc", "(Landroid/graphics/RectF;FF)V");
			global::android.graphics.Path._addRoundRect3577 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "addRoundRect", "(Landroid/graphics/RectF;FFLandroid/graphics/Path$Direction;)V");
			global::android.graphics.Path._addRoundRect3578 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "addRoundRect", "(Landroid/graphics/RectF;[FLandroid/graphics/Path$Direction;)V");
			global::android.graphics.Path._addPath3579 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "addPath", "(Landroid/graphics/Path;)V");
			global::android.graphics.Path._addPath3580 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "addPath", "(Landroid/graphics/Path;Landroid/graphics/Matrix;)V");
			global::android.graphics.Path._addPath3581 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "addPath", "(Landroid/graphics/Path;FF)V");
			global::android.graphics.Path._setLastPoint3582 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "setLastPoint", "(FF)V");
			global::android.graphics.Path._Path3583 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "<init>", "()V");
			global::android.graphics.Path._Path3584 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "<init>", "(Landroid/graphics/Path;)V");
		}
	}
}
