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
			internal static global::MonoJavaBridge.MethodId _values5496;
			public static global::android.graphics.Path.Direction[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.Path.Direction>(@__env.CallStaticObjectMethod(android.graphics.Path.Direction.staticClass, global::android.graphics.Path.Direction._values5496)) as android.graphics.Path.Direction[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf5497;
			public static global::android.graphics.Path.Direction valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.Path.Direction.staticClass, global::android.graphics.Path.Direction._valueOf5497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Path.Direction;
			}
			internal static global::MonoJavaBridge.FieldId _CCW5498;
			public static global::android.graphics.Path.Direction CCW
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.graphics.Path.Direction.staticClass, _CCW5498)) as android.graphics.Path.Direction;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CW5499;
			public static global::android.graphics.Path.Direction CW
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.graphics.Path.Direction.staticClass, _CW5499)) as android.graphics.Path.Direction;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.Path.Direction.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Path$Direction"));
				global::android.graphics.Path.Direction._values5496 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Path.Direction.staticClass, "values", "()[Landroid/graphics/Path/Direction;");
				global::android.graphics.Path.Direction._valueOf5497 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Path.Direction.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Path$Direction;");
				global::android.graphics.Path.Direction._CCW5498 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Path.Direction.staticClass, "CCW", "Landroid/graphics/Path$Direction;");
				global::android.graphics.Path.Direction._CW5499 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Path.Direction.staticClass, "CW", "Landroid/graphics/Path$Direction;");
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
			internal static global::MonoJavaBridge.MethodId _values5500;
			public static global::android.graphics.Path.FillType[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.Path.FillType>(@__env.CallStaticObjectMethod(android.graphics.Path.FillType.staticClass, global::android.graphics.Path.FillType._values5500)) as android.graphics.Path.FillType[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf5501;
			public static global::android.graphics.Path.FillType valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.Path.FillType.staticClass, global::android.graphics.Path.FillType._valueOf5501, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Path.FillType;
			}
			internal static global::MonoJavaBridge.FieldId _EVEN_ODD5502;
			public static global::android.graphics.Path.FillType EVEN_ODD
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.graphics.Path.FillType.staticClass, _EVEN_ODD5502)) as android.graphics.Path.FillType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _INVERSE_EVEN_ODD5503;
			public static global::android.graphics.Path.FillType INVERSE_EVEN_ODD
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.graphics.Path.FillType.staticClass, _INVERSE_EVEN_ODD5503)) as android.graphics.Path.FillType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _INVERSE_WINDING5504;
			public static global::android.graphics.Path.FillType INVERSE_WINDING
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.graphics.Path.FillType.staticClass, _INVERSE_WINDING5504)) as android.graphics.Path.FillType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _WINDING5505;
			public static global::android.graphics.Path.FillType WINDING
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.graphics.Path.FillType.staticClass, _WINDING5505)) as android.graphics.Path.FillType;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.Path.FillType.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Path$FillType"));
				global::android.graphics.Path.FillType._values5500 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Path.FillType.staticClass, "values", "()[Landroid/graphics/Path/FillType;");
				global::android.graphics.Path.FillType._valueOf5501 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Path.FillType.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Path$FillType;");
				global::android.graphics.Path.FillType._EVEN_ODD5502 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Path.FillType.staticClass, "EVEN_ODD", "Landroid/graphics/Path$FillType;");
				global::android.graphics.Path.FillType._INVERSE_EVEN_ODD5503 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Path.FillType.staticClass, "INVERSE_EVEN_ODD", "Landroid/graphics/Path$FillType;");
				global::android.graphics.Path.FillType._INVERSE_WINDING5504 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Path.FillType.staticClass, "INVERSE_WINDING", "Landroid/graphics/Path$FillType;");
				global::android.graphics.Path.FillType._WINDING5505 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Path.FillType.staticClass, "WINDING", "Landroid/graphics/Path$FillType;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _finalize5506;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Path._finalize5506);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._finalize5506);
		}
		internal static global::MonoJavaBridge.MethodId _offset5507;
		public virtual void offset(float arg0, float arg1, android.graphics.Path arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Path._offset5507, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._offset5507, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _offset5508;
		public virtual void offset(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Path._offset5508, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._offset5508, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty5509;
		public virtual bool isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Path._isEmpty5509);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._isEmpty5509);
		}
		internal static global::MonoJavaBridge.MethodId _transform5510;
		public virtual void transform(android.graphics.Matrix arg0, android.graphics.Path arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Path._transform5510, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._transform5510, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _transform5511;
		public virtual void transform(android.graphics.Matrix arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Path._transform5511, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._transform5511, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _close5512;
		public virtual void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Path._close5512);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._close5512);
		}
		internal static global::MonoJavaBridge.MethodId _set5513;
		public virtual void set(android.graphics.Path arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Path._set5513, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._set5513, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reset5514;
		public virtual void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Path._reset5514);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._reset5514);
		}
		internal static global::MonoJavaBridge.MethodId _rewind5515;
		public virtual void rewind() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Path._rewind5515);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._rewind5515);
		}
		internal static global::MonoJavaBridge.MethodId _isRect5516;
		public virtual bool isRect(android.graphics.RectF arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Path._isRect5516, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._isRect5516, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFillType5517;
		public virtual global::android.graphics.Path.FillType getFillType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Path._getFillType5517)) as android.graphics.Path.FillType;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._getFillType5517)) as android.graphics.Path.FillType;
		}
		internal static global::MonoJavaBridge.MethodId _setFillType5518;
		public virtual void setFillType(android.graphics.Path.FillType arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Path._setFillType5518, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._setFillType5518, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isInverseFillType5519;
		public virtual bool isInverseFillType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Path._isInverseFillType5519);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._isInverseFillType5519);
		}
		internal static global::MonoJavaBridge.MethodId _toggleInverseFillType5520;
		public virtual void toggleInverseFillType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Path._toggleInverseFillType5520);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._toggleInverseFillType5520);
		}
		internal static global::MonoJavaBridge.MethodId _computeBounds5521;
		public virtual void computeBounds(android.graphics.RectF arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Path._computeBounds5521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._computeBounds5521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _incReserve5522;
		public virtual void incReserve(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Path._incReserve5522, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._incReserve5522, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _moveTo5523;
		public virtual void moveTo(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Path._moveTo5523, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._moveTo5523, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _rMoveTo5524;
		public virtual void rMoveTo(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Path._rMoveTo5524, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._rMoveTo5524, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _lineTo5525;
		public virtual void lineTo(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Path._lineTo5525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._lineTo5525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _rLineTo5526;
		public virtual void rLineTo(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Path._rLineTo5526, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._rLineTo5526, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _quadTo5527;
		public virtual void quadTo(float arg0, float arg1, float arg2, float arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Path._quadTo5527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._quadTo5527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _rQuadTo5528;
		public virtual void rQuadTo(float arg0, float arg1, float arg2, float arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Path._rQuadTo5528, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._rQuadTo5528, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _cubicTo5529;
		public virtual void cubicTo(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Path._cubicTo5529, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._cubicTo5529, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _rCubicTo5530;
		public virtual void rCubicTo(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Path._rCubicTo5530, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._rCubicTo5530, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _arcTo5531;
		public virtual void arcTo(android.graphics.RectF arg0, float arg1, float arg2, bool arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Path._arcTo5531, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._arcTo5531, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _arcTo5532;
		public virtual void arcTo(android.graphics.RectF arg0, float arg1, float arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Path._arcTo5532, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._arcTo5532, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _addRect5533;
		public virtual void addRect(float arg0, float arg1, float arg2, float arg3, android.graphics.Path.Direction arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Path._addRect5533, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._addRect5533, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _addRect5534;
		public virtual void addRect(android.graphics.RectF arg0, android.graphics.Path.Direction arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Path._addRect5534, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._addRect5534, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addOval5535;
		public virtual void addOval(android.graphics.RectF arg0, android.graphics.Path.Direction arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Path._addOval5535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._addOval5535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addCircle5536;
		public virtual void addCircle(float arg0, float arg1, float arg2, android.graphics.Path.Direction arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Path._addCircle5536, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._addCircle5536, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _addArc5537;
		public virtual void addArc(android.graphics.RectF arg0, float arg1, float arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Path._addArc5537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._addArc5537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _addRoundRect5538;
		public virtual void addRoundRect(android.graphics.RectF arg0, float arg1, float arg2, android.graphics.Path.Direction arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Path._addRoundRect5538, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._addRoundRect5538, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _addRoundRect5539;
		public virtual void addRoundRect(android.graphics.RectF arg0, float[] arg1, android.graphics.Path.Direction arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Path._addRoundRect5539, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._addRoundRect5539, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _addPath5540;
		public virtual void addPath(android.graphics.Path arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Path._addPath5540, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._addPath5540, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addPath5541;
		public virtual void addPath(android.graphics.Path arg0, android.graphics.Matrix arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Path._addPath5541, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._addPath5541, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addPath5542;
		public virtual void addPath(android.graphics.Path arg0, float arg1, float arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Path._addPath5542, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._addPath5542, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setLastPoint5543;
		public virtual void setLastPoint(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Path._setLastPoint5543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Path.staticClass, global::android.graphics.Path._setLastPoint5543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _Path5544;
		public Path()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Path.staticClass, global::android.graphics.Path._Path5544);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Path5545;
		public Path(android.graphics.Path arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Path.staticClass, global::android.graphics.Path._Path5545, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.Path.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Path"));
			global::android.graphics.Path._finalize5506 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "finalize", "()V");
			global::android.graphics.Path._offset5507 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "offset", "(FFLandroid/graphics/Path;)V");
			global::android.graphics.Path._offset5508 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "offset", "(FF)V");
			global::android.graphics.Path._isEmpty5509 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "isEmpty", "()Z");
			global::android.graphics.Path._transform5510 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "transform", "(Landroid/graphics/Matrix;Landroid/graphics/Path;)V");
			global::android.graphics.Path._transform5511 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "transform", "(Landroid/graphics/Matrix;)V");
			global::android.graphics.Path._close5512 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "close", "()V");
			global::android.graphics.Path._set5513 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "set", "(Landroid/graphics/Path;)V");
			global::android.graphics.Path._reset5514 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "reset", "()V");
			global::android.graphics.Path._rewind5515 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "rewind", "()V");
			global::android.graphics.Path._isRect5516 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "isRect", "(Landroid/graphics/RectF;)Z");
			global::android.graphics.Path._getFillType5517 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "getFillType", "()Landroid/graphics/Path$FillType;");
			global::android.graphics.Path._setFillType5518 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "setFillType", "(Landroid/graphics/Path$FillType;)V");
			global::android.graphics.Path._isInverseFillType5519 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "isInverseFillType", "()Z");
			global::android.graphics.Path._toggleInverseFillType5520 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "toggleInverseFillType", "()V");
			global::android.graphics.Path._computeBounds5521 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "computeBounds", "(Landroid/graphics/RectF;Z)V");
			global::android.graphics.Path._incReserve5522 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "incReserve", "(I)V");
			global::android.graphics.Path._moveTo5523 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "moveTo", "(FF)V");
			global::android.graphics.Path._rMoveTo5524 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "rMoveTo", "(FF)V");
			global::android.graphics.Path._lineTo5525 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "lineTo", "(FF)V");
			global::android.graphics.Path._rLineTo5526 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "rLineTo", "(FF)V");
			global::android.graphics.Path._quadTo5527 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "quadTo", "(FFFF)V");
			global::android.graphics.Path._rQuadTo5528 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "rQuadTo", "(FFFF)V");
			global::android.graphics.Path._cubicTo5529 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "cubicTo", "(FFFFFF)V");
			global::android.graphics.Path._rCubicTo5530 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "rCubicTo", "(FFFFFF)V");
			global::android.graphics.Path._arcTo5531 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "arcTo", "(Landroid/graphics/RectF;FFZ)V");
			global::android.graphics.Path._arcTo5532 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "arcTo", "(Landroid/graphics/RectF;FF)V");
			global::android.graphics.Path._addRect5533 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "addRect", "(FFFFLandroid/graphics/Path$Direction;)V");
			global::android.graphics.Path._addRect5534 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "addRect", "(Landroid/graphics/RectF;Landroid/graphics/Path$Direction;)V");
			global::android.graphics.Path._addOval5535 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "addOval", "(Landroid/graphics/RectF;Landroid/graphics/Path$Direction;)V");
			global::android.graphics.Path._addCircle5536 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "addCircle", "(FFFLandroid/graphics/Path$Direction;)V");
			global::android.graphics.Path._addArc5537 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "addArc", "(Landroid/graphics/RectF;FF)V");
			global::android.graphics.Path._addRoundRect5538 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "addRoundRect", "(Landroid/graphics/RectF;FFLandroid/graphics/Path$Direction;)V");
			global::android.graphics.Path._addRoundRect5539 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "addRoundRect", "(Landroid/graphics/RectF;[FLandroid/graphics/Path$Direction;)V");
			global::android.graphics.Path._addPath5540 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "addPath", "(Landroid/graphics/Path;)V");
			global::android.graphics.Path._addPath5541 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "addPath", "(Landroid/graphics/Path;Landroid/graphics/Matrix;)V");
			global::android.graphics.Path._addPath5542 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "addPath", "(Landroid/graphics/Path;FF)V");
			global::android.graphics.Path._setLastPoint5543 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "setLastPoint", "(FF)V");
			global::android.graphics.Path._Path5544 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "<init>", "()V");
			global::android.graphics.Path._Path5545 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "<init>", "(Landroid/graphics/Path;)V");
		}
	}
}
