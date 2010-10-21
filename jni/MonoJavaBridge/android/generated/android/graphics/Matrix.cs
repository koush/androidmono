namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Matrix : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Matrix()
		{
			InitJNI();
		}
		protected Matrix(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class ScaleToFit : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static ScaleToFit()
			{
				InitJNI();
			}
			internal ScaleToFit(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values5281;
			public static global::android.graphics.Matrix.ScaleToFit[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.Matrix.ScaleToFit>(@__env.CallStaticObjectMethod(android.graphics.Matrix.ScaleToFit.staticClass, global::android.graphics.Matrix.ScaleToFit._values5281)) as android.graphics.Matrix.ScaleToFit[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf5282;
			public static global::android.graphics.Matrix.ScaleToFit valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.Matrix.ScaleToFit.staticClass, global::android.graphics.Matrix.ScaleToFit._valueOf5282, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Matrix.ScaleToFit;
			}
			internal static global::MonoJavaBridge.FieldId _CENTER5283;
			public static global::android.graphics.Matrix.ScaleToFit CENTER
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.graphics.Matrix.ScaleToFit.staticClass, _CENTER5283)) as android.graphics.Matrix.ScaleToFit;
				}
			}
			internal static global::MonoJavaBridge.FieldId _END5284;
			public static global::android.graphics.Matrix.ScaleToFit END
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.graphics.Matrix.ScaleToFit.staticClass, _END5284)) as android.graphics.Matrix.ScaleToFit;
				}
			}
			internal static global::MonoJavaBridge.FieldId _FILL5285;
			public static global::android.graphics.Matrix.ScaleToFit FILL
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.graphics.Matrix.ScaleToFit.staticClass, _FILL5285)) as android.graphics.Matrix.ScaleToFit;
				}
			}
			internal static global::MonoJavaBridge.FieldId _START5286;
			public static global::android.graphics.Matrix.ScaleToFit START
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.graphics.Matrix.ScaleToFit.staticClass, _START5286)) as android.graphics.Matrix.ScaleToFit;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.Matrix.ScaleToFit.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Matrix$ScaleToFit"));
				global::android.graphics.Matrix.ScaleToFit._values5281 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Matrix.ScaleToFit.staticClass, "values", "()[Landroid/graphics/Matrix/ScaleToFit;");
				global::android.graphics.Matrix.ScaleToFit._valueOf5282 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Matrix.ScaleToFit.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Matrix$ScaleToFit;");
				global::android.graphics.Matrix.ScaleToFit._CENTER5283 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Matrix.ScaleToFit.staticClass, "CENTER", "Landroid/graphics/Matrix$ScaleToFit;");
				global::android.graphics.Matrix.ScaleToFit._END5284 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Matrix.ScaleToFit.staticClass, "END", "Landroid/graphics/Matrix$ScaleToFit;");
				global::android.graphics.Matrix.ScaleToFit._FILL5285 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Matrix.ScaleToFit.staticClass, "FILL", "Landroid/graphics/Matrix$ScaleToFit;");
				global::android.graphics.Matrix.ScaleToFit._START5286 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Matrix.ScaleToFit.staticClass, "START", "Landroid/graphics/Matrix$ScaleToFit;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _finalize5287;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Matrix._finalize5287);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._finalize5287);
		}
		internal static global::MonoJavaBridge.MethodId _equals5288;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Matrix._equals5288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._equals5288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString5289;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Matrix._toString5289)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._toString5289)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _set5290;
		public virtual void set(android.graphics.Matrix arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Matrix._set5290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._set5290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reset5291;
		public virtual void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Matrix._reset5291);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._reset5291);
		}
		internal static global::MonoJavaBridge.MethodId _toShortString5292;
		public virtual global::java.lang.String toShortString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Matrix._toShortString5292)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._toShortString5292)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getValues5293;
		public virtual void getValues(float[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Matrix._getValues5293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._getValues5293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isIdentity5294;
		public virtual bool isIdentity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Matrix._isIdentity5294);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._isIdentity5294);
		}
		internal static global::MonoJavaBridge.MethodId _rectStaysRect5295;
		public virtual bool rectStaysRect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Matrix._rectStaysRect5295);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._rectStaysRect5295);
		}
		internal static global::MonoJavaBridge.MethodId _setTranslate5296;
		public virtual void setTranslate(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Matrix._setTranslate5296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._setTranslate5296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setScale5297;
		public virtual void setScale(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Matrix._setScale5297, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._setScale5297, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setScale5298;
		public virtual void setScale(float arg0, float arg1, float arg2, float arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Matrix._setScale5298, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._setScale5298, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setRotate5299;
		public virtual void setRotate(float arg0, float arg1, float arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Matrix._setRotate5299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._setRotate5299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setRotate5300;
		public virtual void setRotate(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Matrix._setRotate5300, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._setRotate5300, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSinCos5301;
		public virtual void setSinCos(float arg0, float arg1, float arg2, float arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Matrix._setSinCos5301, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._setSinCos5301, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setSinCos5302;
		public virtual void setSinCos(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Matrix._setSinCos5302, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._setSinCos5302, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setSkew5303;
		public virtual void setSkew(float arg0, float arg1, float arg2, float arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Matrix._setSkew5303, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._setSkew5303, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setSkew5304;
		public virtual void setSkew(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Matrix._setSkew5304, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._setSkew5304, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setConcat5305;
		public virtual bool setConcat(android.graphics.Matrix arg0, android.graphics.Matrix arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Matrix._setConcat5305, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._setConcat5305, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _preTranslate5306;
		public virtual bool preTranslate(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Matrix._preTranslate5306, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._preTranslate5306, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _preScale5307;
		public virtual bool preScale(float arg0, float arg1, float arg2, float arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Matrix._preScale5307, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._preScale5307, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _preScale5308;
		public virtual bool preScale(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Matrix._preScale5308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._preScale5308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _preRotate5309;
		public virtual bool preRotate(float arg0, float arg1, float arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Matrix._preRotate5309, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._preRotate5309, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _preRotate5310;
		public virtual bool preRotate(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Matrix._preRotate5310, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._preRotate5310, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _preSkew5311;
		public virtual bool preSkew(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Matrix._preSkew5311, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._preSkew5311, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _preSkew5312;
		public virtual bool preSkew(float arg0, float arg1, float arg2, float arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Matrix._preSkew5312, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._preSkew5312, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _preConcat5313;
		public virtual bool preConcat(android.graphics.Matrix arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Matrix._preConcat5313, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._preConcat5313, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _postTranslate5314;
		public virtual bool postTranslate(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Matrix._postTranslate5314, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._postTranslate5314, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _postScale5315;
		public virtual bool postScale(float arg0, float arg1, float arg2, float arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Matrix._postScale5315, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._postScale5315, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _postScale5316;
		public virtual bool postScale(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Matrix._postScale5316, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._postScale5316, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _postRotate5317;
		public virtual bool postRotate(float arg0, float arg1, float arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Matrix._postRotate5317, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._postRotate5317, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _postRotate5318;
		public virtual bool postRotate(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Matrix._postRotate5318, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._postRotate5318, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _postSkew5319;
		public virtual bool postSkew(float arg0, float arg1, float arg2, float arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Matrix._postSkew5319, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._postSkew5319, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _postSkew5320;
		public virtual bool postSkew(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Matrix._postSkew5320, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._postSkew5320, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _postConcat5321;
		public virtual bool postConcat(android.graphics.Matrix arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Matrix._postConcat5321, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._postConcat5321, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setRectToRect5322;
		public virtual bool setRectToRect(android.graphics.RectF arg0, android.graphics.RectF arg1, android.graphics.Matrix.ScaleToFit arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Matrix._setRectToRect5322, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._setRectToRect5322, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setPolyToPoly5323;
		public virtual bool setPolyToPoly(float[] arg0, int arg1, float[] arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Matrix._setPolyToPoly5323, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._setPolyToPoly5323, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _invert5324;
		public virtual bool invert(android.graphics.Matrix arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Matrix._invert5324, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._invert5324, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _mapPoints5325;
		public virtual void mapPoints(float[] arg0, int arg1, float[] arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Matrix._mapPoints5325, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._mapPoints5325, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _mapPoints5326;
		public virtual void mapPoints(float[] arg0, float[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Matrix._mapPoints5326, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._mapPoints5326, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _mapPoints5327;
		public virtual void mapPoints(float[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Matrix._mapPoints5327, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._mapPoints5327, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _mapVectors5328;
		public virtual void mapVectors(float[] arg0, int arg1, float[] arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Matrix._mapVectors5328, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._mapVectors5328, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _mapVectors5329;
		public virtual void mapVectors(float[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Matrix._mapVectors5329, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._mapVectors5329, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _mapVectors5330;
		public virtual void mapVectors(float[] arg0, float[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Matrix._mapVectors5330, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._mapVectors5330, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _mapRect5331;
		public virtual bool mapRect(android.graphics.RectF arg0, android.graphics.RectF arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Matrix._mapRect5331, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._mapRect5331, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _mapRect5332;
		public virtual bool mapRect(android.graphics.RectF arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Matrix._mapRect5332, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._mapRect5332, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _mapRadius5333;
		public virtual float mapRadius(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.graphics.Matrix._mapRadius5333, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._mapRadius5333, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setValues5334;
		public virtual void setValues(float[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Matrix._setValues5334, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._setValues5334, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Matrix5335;
		public Matrix()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Matrix.staticClass, global::android.graphics.Matrix._Matrix5335);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Matrix5336;
		public Matrix(android.graphics.Matrix arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Matrix.staticClass, global::android.graphics.Matrix._Matrix5336, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static int MSCALE_X
		{
			get
			{
				return 0;
			}
		}
		public static int MSKEW_X
		{
			get
			{
				return 1;
			}
		}
		public static int MTRANS_X
		{
			get
			{
				return 2;
			}
		}
		public static int MSKEW_Y
		{
			get
			{
				return 3;
			}
		}
		public static int MSCALE_Y
		{
			get
			{
				return 4;
			}
		}
		public static int MTRANS_Y
		{
			get
			{
				return 5;
			}
		}
		public static int MPERSP_0
		{
			get
			{
				return 6;
			}
		}
		public static int MPERSP_1
		{
			get
			{
				return 7;
			}
		}
		public static int MPERSP_2
		{
			get
			{
				return 8;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.Matrix.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Matrix"));
			global::android.graphics.Matrix._finalize5287 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "finalize", "()V");
			global::android.graphics.Matrix._equals5288 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.graphics.Matrix._toString5289 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "toString", "()Ljava/lang/String;");
			global::android.graphics.Matrix._set5290 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "set", "(Landroid/graphics/Matrix;)V");
			global::android.graphics.Matrix._reset5291 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "reset", "()V");
			global::android.graphics.Matrix._toShortString5292 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "toShortString", "()Ljava/lang/String;");
			global::android.graphics.Matrix._getValues5293 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "getValues", "([F)V");
			global::android.graphics.Matrix._isIdentity5294 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "isIdentity", "()Z");
			global::android.graphics.Matrix._rectStaysRect5295 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "rectStaysRect", "()Z");
			global::android.graphics.Matrix._setTranslate5296 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "setTranslate", "(FF)V");
			global::android.graphics.Matrix._setScale5297 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "setScale", "(FF)V");
			global::android.graphics.Matrix._setScale5298 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "setScale", "(FFFF)V");
			global::android.graphics.Matrix._setRotate5299 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "setRotate", "(FFF)V");
			global::android.graphics.Matrix._setRotate5300 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "setRotate", "(F)V");
			global::android.graphics.Matrix._setSinCos5301 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "setSinCos", "(FFFF)V");
			global::android.graphics.Matrix._setSinCos5302 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "setSinCos", "(FF)V");
			global::android.graphics.Matrix._setSkew5303 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "setSkew", "(FFFF)V");
			global::android.graphics.Matrix._setSkew5304 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "setSkew", "(FF)V");
			global::android.graphics.Matrix._setConcat5305 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "setConcat", "(Landroid/graphics/Matrix;Landroid/graphics/Matrix;)Z");
			global::android.graphics.Matrix._preTranslate5306 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "preTranslate", "(FF)Z");
			global::android.graphics.Matrix._preScale5307 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "preScale", "(FFFF)Z");
			global::android.graphics.Matrix._preScale5308 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "preScale", "(FF)Z");
			global::android.graphics.Matrix._preRotate5309 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "preRotate", "(FFF)Z");
			global::android.graphics.Matrix._preRotate5310 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "preRotate", "(F)Z");
			global::android.graphics.Matrix._preSkew5311 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "preSkew", "(FF)Z");
			global::android.graphics.Matrix._preSkew5312 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "preSkew", "(FFFF)Z");
			global::android.graphics.Matrix._preConcat5313 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "preConcat", "(Landroid/graphics/Matrix;)Z");
			global::android.graphics.Matrix._postTranslate5314 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "postTranslate", "(FF)Z");
			global::android.graphics.Matrix._postScale5315 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "postScale", "(FFFF)Z");
			global::android.graphics.Matrix._postScale5316 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "postScale", "(FF)Z");
			global::android.graphics.Matrix._postRotate5317 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "postRotate", "(FFF)Z");
			global::android.graphics.Matrix._postRotate5318 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "postRotate", "(F)Z");
			global::android.graphics.Matrix._postSkew5319 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "postSkew", "(FFFF)Z");
			global::android.graphics.Matrix._postSkew5320 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "postSkew", "(FF)Z");
			global::android.graphics.Matrix._postConcat5321 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "postConcat", "(Landroid/graphics/Matrix;)Z");
			global::android.graphics.Matrix._setRectToRect5322 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "setRectToRect", "(Landroid/graphics/RectF;Landroid/graphics/RectF;Landroid/graphics/Matrix$ScaleToFit;)Z");
			global::android.graphics.Matrix._setPolyToPoly5323 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "setPolyToPoly", "([FI[FII)Z");
			global::android.graphics.Matrix._invert5324 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "invert", "(Landroid/graphics/Matrix;)Z");
			global::android.graphics.Matrix._mapPoints5325 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "mapPoints", "([FI[FII)V");
			global::android.graphics.Matrix._mapPoints5326 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "mapPoints", "([F[F)V");
			global::android.graphics.Matrix._mapPoints5327 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "mapPoints", "([F)V");
			global::android.graphics.Matrix._mapVectors5328 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "mapVectors", "([FI[FII)V");
			global::android.graphics.Matrix._mapVectors5329 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "mapVectors", "([F)V");
			global::android.graphics.Matrix._mapVectors5330 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "mapVectors", "([F[F)V");
			global::android.graphics.Matrix._mapRect5331 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "mapRect", "(Landroid/graphics/RectF;Landroid/graphics/RectF;)Z");
			global::android.graphics.Matrix._mapRect5332 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "mapRect", "(Landroid/graphics/RectF;)Z");
			global::android.graphics.Matrix._mapRadius5333 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "mapRadius", "(F)F");
			global::android.graphics.Matrix._setValues5334 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "setValues", "([F)V");
			global::android.graphics.Matrix._Matrix5335 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "<init>", "()V");
			global::android.graphics.Matrix._Matrix5336 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "<init>", "(Landroid/graphics/Matrix;)V");
		}
	}
}
