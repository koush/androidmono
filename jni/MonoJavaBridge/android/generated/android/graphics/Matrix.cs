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
			internal static global::MonoJavaBridge.MethodId _values3338;
			public static global::android.graphics.Matrix.ScaleToFit[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.Matrix.ScaleToFit>(@__env.CallStaticObjectMethod(android.graphics.Matrix.ScaleToFit.staticClass, global::android.graphics.Matrix.ScaleToFit._values3338)) as android.graphics.Matrix.ScaleToFit[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf3339;
			public static global::android.graphics.Matrix.ScaleToFit valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.Matrix.ScaleToFit.staticClass, global::android.graphics.Matrix.ScaleToFit._valueOf3339, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Matrix.ScaleToFit;
			}
			internal static global::MonoJavaBridge.FieldId _CENTER3340;
			public static global::android.graphics.Matrix.ScaleToFit CENTER
			{
				get
				{
					return default(global::android.graphics.Matrix.ScaleToFit);
				}
			}
			internal static global::MonoJavaBridge.FieldId _END3341;
			public static global::android.graphics.Matrix.ScaleToFit END
			{
				get
				{
					return default(global::android.graphics.Matrix.ScaleToFit);
				}
			}
			internal static global::MonoJavaBridge.FieldId _FILL3342;
			public static global::android.graphics.Matrix.ScaleToFit FILL
			{
				get
				{
					return default(global::android.graphics.Matrix.ScaleToFit);
				}
			}
			internal static global::MonoJavaBridge.FieldId _START3343;
			public static global::android.graphics.Matrix.ScaleToFit START
			{
				get
				{
					return default(global::android.graphics.Matrix.ScaleToFit);
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.Matrix.ScaleToFit.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Matrix$ScaleToFit"));
				global::android.graphics.Matrix.ScaleToFit._values3338 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Matrix.ScaleToFit.staticClass, "values", "()[Landroid/graphics/Matrix/ScaleToFit;");
				global::android.graphics.Matrix.ScaleToFit._valueOf3339 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Matrix.ScaleToFit.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Matrix$ScaleToFit;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _finalize3344;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Matrix._finalize3344);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._finalize3344);
		}
		internal static global::MonoJavaBridge.MethodId _equals3345;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Matrix._equals3345, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._equals3345, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString3346;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Matrix._toString3346)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._toString3346)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _set3347;
		public virtual void set(android.graphics.Matrix arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Matrix._set3347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._set3347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reset3348;
		public virtual void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Matrix._reset3348);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._reset3348);
		}
		internal static global::MonoJavaBridge.MethodId _toShortString3349;
		public virtual global::java.lang.String toShortString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Matrix._toShortString3349)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._toShortString3349)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getValues3350;
		public virtual void getValues(float[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Matrix._getValues3350, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._getValues3350, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isIdentity3351;
		public virtual bool isIdentity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Matrix._isIdentity3351);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._isIdentity3351);
		}
		internal static global::MonoJavaBridge.MethodId _rectStaysRect3352;
		public virtual bool rectStaysRect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Matrix._rectStaysRect3352);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._rectStaysRect3352);
		}
		internal static global::MonoJavaBridge.MethodId _setTranslate3353;
		public virtual void setTranslate(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Matrix._setTranslate3353, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._setTranslate3353, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setScale3354;
		public virtual void setScale(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Matrix._setScale3354, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._setScale3354, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setScale3355;
		public virtual void setScale(float arg0, float arg1, float arg2, float arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Matrix._setScale3355, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._setScale3355, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setRotate3356;
		public virtual void setRotate(float arg0, float arg1, float arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Matrix._setRotate3356, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._setRotate3356, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setRotate3357;
		public virtual void setRotate(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Matrix._setRotate3357, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._setRotate3357, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSinCos3358;
		public virtual void setSinCos(float arg0, float arg1, float arg2, float arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Matrix._setSinCos3358, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._setSinCos3358, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setSinCos3359;
		public virtual void setSinCos(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Matrix._setSinCos3359, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._setSinCos3359, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setSkew3360;
		public virtual void setSkew(float arg0, float arg1, float arg2, float arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Matrix._setSkew3360, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._setSkew3360, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setSkew3361;
		public virtual void setSkew(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Matrix._setSkew3361, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._setSkew3361, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setConcat3362;
		public virtual bool setConcat(android.graphics.Matrix arg0, android.graphics.Matrix arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Matrix._setConcat3362, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._setConcat3362, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _preTranslate3363;
		public virtual bool preTranslate(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Matrix._preTranslate3363, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._preTranslate3363, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _preScale3364;
		public virtual bool preScale(float arg0, float arg1, float arg2, float arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Matrix._preScale3364, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._preScale3364, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _preScale3365;
		public virtual bool preScale(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Matrix._preScale3365, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._preScale3365, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _preRotate3366;
		public virtual bool preRotate(float arg0, float arg1, float arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Matrix._preRotate3366, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._preRotate3366, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _preRotate3367;
		public virtual bool preRotate(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Matrix._preRotate3367, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._preRotate3367, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _preSkew3368;
		public virtual bool preSkew(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Matrix._preSkew3368, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._preSkew3368, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _preSkew3369;
		public virtual bool preSkew(float arg0, float arg1, float arg2, float arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Matrix._preSkew3369, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._preSkew3369, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _preConcat3370;
		public virtual bool preConcat(android.graphics.Matrix arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Matrix._preConcat3370, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._preConcat3370, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _postTranslate3371;
		public virtual bool postTranslate(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Matrix._postTranslate3371, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._postTranslate3371, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _postScale3372;
		public virtual bool postScale(float arg0, float arg1, float arg2, float arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Matrix._postScale3372, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._postScale3372, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _postScale3373;
		public virtual bool postScale(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Matrix._postScale3373, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._postScale3373, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _postRotate3374;
		public virtual bool postRotate(float arg0, float arg1, float arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Matrix._postRotate3374, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._postRotate3374, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _postRotate3375;
		public virtual bool postRotate(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Matrix._postRotate3375, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._postRotate3375, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _postSkew3376;
		public virtual bool postSkew(float arg0, float arg1, float arg2, float arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Matrix._postSkew3376, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._postSkew3376, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _postSkew3377;
		public virtual bool postSkew(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Matrix._postSkew3377, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._postSkew3377, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _postConcat3378;
		public virtual bool postConcat(android.graphics.Matrix arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Matrix._postConcat3378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._postConcat3378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setRectToRect3379;
		public virtual bool setRectToRect(android.graphics.RectF arg0, android.graphics.RectF arg1, android.graphics.Matrix.ScaleToFit arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Matrix._setRectToRect3379, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._setRectToRect3379, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setPolyToPoly3380;
		public virtual bool setPolyToPoly(float[] arg0, int arg1, float[] arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Matrix._setPolyToPoly3380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._setPolyToPoly3380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _invert3381;
		public virtual bool invert(android.graphics.Matrix arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Matrix._invert3381, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._invert3381, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _mapPoints3382;
		public virtual void mapPoints(float[] arg0, int arg1, float[] arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Matrix._mapPoints3382, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._mapPoints3382, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _mapPoints3383;
		public virtual void mapPoints(float[] arg0, float[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Matrix._mapPoints3383, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._mapPoints3383, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _mapPoints3384;
		public virtual void mapPoints(float[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Matrix._mapPoints3384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._mapPoints3384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _mapVectors3385;
		public virtual void mapVectors(float[] arg0, int arg1, float[] arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Matrix._mapVectors3385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._mapVectors3385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _mapVectors3386;
		public virtual void mapVectors(float[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Matrix._mapVectors3386, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._mapVectors3386, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _mapVectors3387;
		public virtual void mapVectors(float[] arg0, float[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Matrix._mapVectors3387, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._mapVectors3387, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _mapRect3388;
		public virtual bool mapRect(android.graphics.RectF arg0, android.graphics.RectF arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Matrix._mapRect3388, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._mapRect3388, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _mapRect3389;
		public virtual bool mapRect(android.graphics.RectF arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Matrix._mapRect3389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._mapRect3389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _mapRadius3390;
		public virtual float mapRadius(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.graphics.Matrix._mapRadius3390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._mapRadius3390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setValues3391;
		public virtual void setValues(float[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Matrix._setValues3391, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._setValues3391, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Matrix3392;
		public Matrix()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Matrix.staticClass, global::android.graphics.Matrix._Matrix3392);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Matrix3393;
		public Matrix(android.graphics.Matrix arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Matrix.staticClass, global::android.graphics.Matrix._Matrix3393, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			global::android.graphics.Matrix._finalize3344 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "finalize", "()V");
			global::android.graphics.Matrix._equals3345 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.graphics.Matrix._toString3346 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "toString", "()Ljava/lang/String;");
			global::android.graphics.Matrix._set3347 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "set", "(Landroid/graphics/Matrix;)V");
			global::android.graphics.Matrix._reset3348 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "reset", "()V");
			global::android.graphics.Matrix._toShortString3349 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "toShortString", "()Ljava/lang/String;");
			global::android.graphics.Matrix._getValues3350 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "getValues", "([F)V");
			global::android.graphics.Matrix._isIdentity3351 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "isIdentity", "()Z");
			global::android.graphics.Matrix._rectStaysRect3352 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "rectStaysRect", "()Z");
			global::android.graphics.Matrix._setTranslate3353 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "setTranslate", "(FF)V");
			global::android.graphics.Matrix._setScale3354 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "setScale", "(FF)V");
			global::android.graphics.Matrix._setScale3355 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "setScale", "(FFFF)V");
			global::android.graphics.Matrix._setRotate3356 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "setRotate", "(FFF)V");
			global::android.graphics.Matrix._setRotate3357 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "setRotate", "(F)V");
			global::android.graphics.Matrix._setSinCos3358 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "setSinCos", "(FFFF)V");
			global::android.graphics.Matrix._setSinCos3359 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "setSinCos", "(FF)V");
			global::android.graphics.Matrix._setSkew3360 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "setSkew", "(FFFF)V");
			global::android.graphics.Matrix._setSkew3361 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "setSkew", "(FF)V");
			global::android.graphics.Matrix._setConcat3362 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "setConcat", "(Landroid/graphics/Matrix;Landroid/graphics/Matrix;)Z");
			global::android.graphics.Matrix._preTranslate3363 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "preTranslate", "(FF)Z");
			global::android.graphics.Matrix._preScale3364 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "preScale", "(FFFF)Z");
			global::android.graphics.Matrix._preScale3365 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "preScale", "(FF)Z");
			global::android.graphics.Matrix._preRotate3366 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "preRotate", "(FFF)Z");
			global::android.graphics.Matrix._preRotate3367 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "preRotate", "(F)Z");
			global::android.graphics.Matrix._preSkew3368 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "preSkew", "(FF)Z");
			global::android.graphics.Matrix._preSkew3369 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "preSkew", "(FFFF)Z");
			global::android.graphics.Matrix._preConcat3370 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "preConcat", "(Landroid/graphics/Matrix;)Z");
			global::android.graphics.Matrix._postTranslate3371 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "postTranslate", "(FF)Z");
			global::android.graphics.Matrix._postScale3372 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "postScale", "(FFFF)Z");
			global::android.graphics.Matrix._postScale3373 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "postScale", "(FF)Z");
			global::android.graphics.Matrix._postRotate3374 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "postRotate", "(FFF)Z");
			global::android.graphics.Matrix._postRotate3375 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "postRotate", "(F)Z");
			global::android.graphics.Matrix._postSkew3376 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "postSkew", "(FFFF)Z");
			global::android.graphics.Matrix._postSkew3377 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "postSkew", "(FF)Z");
			global::android.graphics.Matrix._postConcat3378 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "postConcat", "(Landroid/graphics/Matrix;)Z");
			global::android.graphics.Matrix._setRectToRect3379 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "setRectToRect", "(Landroid/graphics/RectF;Landroid/graphics/RectF;Landroid/graphics/Matrix$ScaleToFit;)Z");
			global::android.graphics.Matrix._setPolyToPoly3380 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "setPolyToPoly", "([FI[FII)Z");
			global::android.graphics.Matrix._invert3381 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "invert", "(Landroid/graphics/Matrix;)Z");
			global::android.graphics.Matrix._mapPoints3382 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "mapPoints", "([FI[FII)V");
			global::android.graphics.Matrix._mapPoints3383 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "mapPoints", "([F[F)V");
			global::android.graphics.Matrix._mapPoints3384 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "mapPoints", "([F)V");
			global::android.graphics.Matrix._mapVectors3385 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "mapVectors", "([FI[FII)V");
			global::android.graphics.Matrix._mapVectors3386 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "mapVectors", "([F)V");
			global::android.graphics.Matrix._mapVectors3387 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "mapVectors", "([F[F)V");
			global::android.graphics.Matrix._mapRect3388 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "mapRect", "(Landroid/graphics/RectF;Landroid/graphics/RectF;)Z");
			global::android.graphics.Matrix._mapRect3389 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "mapRect", "(Landroid/graphics/RectF;)Z");
			global::android.graphics.Matrix._mapRadius3390 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "mapRadius", "(F)F");
			global::android.graphics.Matrix._setValues3391 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "setValues", "([F)V");
			global::android.graphics.Matrix._Matrix3392 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "<init>", "()V");
			global::android.graphics.Matrix._Matrix3393 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "<init>", "(Landroid/graphics/Matrix;)V");
		}
	}
}
