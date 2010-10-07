namespace android.graphics
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class Matrix : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static Matrix()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.Matrix), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.graphics.Matrix(@__env);
			}
		}
		protected Matrix(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class ScaleToFit : java.lang.Enum
		{
			internal new static global::java.lang.Class staticClass;
			static ScaleToFit()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.Matrix.ScaleToFit), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.graphics.Matrix.ScaleToFit(@__env);
				}
			}
			internal ScaleToFit(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _values3158;
			public static global::android.graphics.Matrix.ScaleToFit[] values() 
			{
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Matrix.ScaleToFit.staticClass, global::android.graphics.Matrix.ScaleToFit._values3158));
			}
			internal static global::net.sf.jni4net.jni.MethodId _valueOf3159;
			public static global::android.graphics.Matrix.ScaleToFit valueOf(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Matrix.ScaleToFit>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Matrix.ScaleToFit.staticClass, global::android.graphics.Matrix.ScaleToFit._valueOf3159, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			}
			internal static global::net.sf.jni4net.jni.FieldId _CENTER3160;
			public static global::android.graphics.Matrix.ScaleToFit CENTER
			{
				get
				{
					return default(global::android.graphics.Matrix.ScaleToFit);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _END3161;
			public static global::android.graphics.Matrix.ScaleToFit END
			{
				get
				{
					return default(global::android.graphics.Matrix.ScaleToFit);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _FILL3162;
			public static global::android.graphics.Matrix.ScaleToFit FILL
			{
				get
				{
					return default(global::android.graphics.Matrix.ScaleToFit);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _START3163;
			public static global::android.graphics.Matrix.ScaleToFit START
			{
				get
				{
					return default(global::android.graphics.Matrix.ScaleToFit);
				}
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.graphics.Matrix.ScaleToFit.staticClass = @__class;
				global::android.graphics.Matrix.ScaleToFit._values3158 = @__env.GetStaticMethodID(global::android.graphics.Matrix.ScaleToFit.staticClass, "values", "()[Landroid/graphics/Matrix/ScaleToFit;");
				global::android.graphics.Matrix.ScaleToFit._valueOf3159 = @__env.GetStaticMethodID(global::android.graphics.Matrix.ScaleToFit.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Matrix$ScaleToFit;");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _equals3164;
		public override bool equals(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Matrix._equals3164, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._equals3164, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString3165;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.Matrix._toString3165));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._toString3165));
		}
		internal static global::net.sf.jni4net.jni.MethodId _set3166;
		public virtual void set(android.graphics.Matrix arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Matrix._set3166, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._set3166, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _reset3167;
		public virtual void reset() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Matrix._reset3167);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._reset3167);
		}
		internal static global::net.sf.jni4net.jni.MethodId _toShortString3168;
		public virtual global::java.lang.String toShortString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.Matrix._toShortString3168));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._toShortString3168));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getValues3169;
		public virtual void getValues(float[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Matrix._getValues3169, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._getValues3169, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isIdentity3170;
		public virtual bool isIdentity() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Matrix._isIdentity3170);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._isIdentity3170);
		}
		internal static global::net.sf.jni4net.jni.MethodId _rectStaysRect3171;
		public virtual bool rectStaysRect() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Matrix._rectStaysRect3171);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._rectStaysRect3171);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTranslate3172;
		public virtual void setTranslate(float arg0, float arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Matrix._setTranslate3172, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._setTranslate3172, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setScale3173;
		public virtual void setScale(float arg0, float arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Matrix._setScale3173, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._setScale3173, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setScale3174;
		public virtual void setScale(float arg0, float arg1, float arg2, float arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Matrix._setScale3174, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._setScale3174, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setRotate3175;
		public virtual void setRotate(float arg0, float arg1, float arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Matrix._setRotate3175, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._setRotate3175, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setRotate3176;
		public virtual void setRotate(float arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Matrix._setRotate3176, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._setRotate3176, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSinCos3177;
		public virtual void setSinCos(float arg0, float arg1, float arg2, float arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Matrix._setSinCos3177, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._setSinCos3177, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSinCos3178;
		public virtual void setSinCos(float arg0, float arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Matrix._setSinCos3178, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._setSinCos3178, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSkew3179;
		public virtual void setSkew(float arg0, float arg1, float arg2, float arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Matrix._setSkew3179, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._setSkew3179, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSkew3180;
		public virtual void setSkew(float arg0, float arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Matrix._setSkew3180, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._setSkew3180, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setConcat3181;
		public virtual bool setConcat(android.graphics.Matrix arg0, android.graphics.Matrix arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Matrix._setConcat3181, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._setConcat3181, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _preTranslate3182;
		public virtual bool preTranslate(float arg0, float arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Matrix._preTranslate3182, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._preTranslate3182, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _preScale3183;
		public virtual bool preScale(float arg0, float arg1, float arg2, float arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Matrix._preScale3183, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._preScale3183, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _preScale3184;
		public virtual bool preScale(float arg0, float arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Matrix._preScale3184, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._preScale3184, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _preRotate3185;
		public virtual bool preRotate(float arg0, float arg1, float arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Matrix._preRotate3185, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._preRotate3185, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _preRotate3186;
		public virtual bool preRotate(float arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Matrix._preRotate3186, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._preRotate3186, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _preSkew3187;
		public virtual bool preSkew(float arg0, float arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Matrix._preSkew3187, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._preSkew3187, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _preSkew3188;
		public virtual bool preSkew(float arg0, float arg1, float arg2, float arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Matrix._preSkew3188, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._preSkew3188, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _preConcat3189;
		public virtual bool preConcat(android.graphics.Matrix arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Matrix._preConcat3189, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._preConcat3189, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _postTranslate3190;
		public virtual bool postTranslate(float arg0, float arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Matrix._postTranslate3190, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._postTranslate3190, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _postScale3191;
		public virtual bool postScale(float arg0, float arg1, float arg2, float arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Matrix._postScale3191, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._postScale3191, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _postScale3192;
		public virtual bool postScale(float arg0, float arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Matrix._postScale3192, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._postScale3192, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _postRotate3193;
		public virtual bool postRotate(float arg0, float arg1, float arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Matrix._postRotate3193, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._postRotate3193, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _postRotate3194;
		public virtual bool postRotate(float arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Matrix._postRotate3194, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._postRotate3194, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _postSkew3195;
		public virtual bool postSkew(float arg0, float arg1, float arg2, float arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Matrix._postSkew3195, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._postSkew3195, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _postSkew3196;
		public virtual bool postSkew(float arg0, float arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Matrix._postSkew3196, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._postSkew3196, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _postConcat3197;
		public virtual bool postConcat(android.graphics.Matrix arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Matrix._postConcat3197, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._postConcat3197, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setRectToRect3198;
		public virtual bool setRectToRect(android.graphics.RectF arg0, android.graphics.RectF arg1, android.graphics.Matrix.ScaleToFit arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Matrix._setRectToRect3198, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._setRectToRect3198, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setPolyToPoly3199;
		public virtual bool setPolyToPoly(float[] arg0, int arg1, float[] arg2, int arg3, int arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Matrix._setPolyToPoly3199, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._setPolyToPoly3199, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _invert3200;
		public virtual bool invert(android.graphics.Matrix arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Matrix._invert3200, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._invert3200, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _mapPoints3201;
		public virtual void mapPoints(float[] arg0, int arg1, float[] arg2, int arg3, int arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Matrix._mapPoints3201, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._mapPoints3201, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _mapPoints3202;
		public virtual void mapPoints(float[] arg0, float[] arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Matrix._mapPoints3202, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._mapPoints3202, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _mapPoints3203;
		public virtual void mapPoints(float[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Matrix._mapPoints3203, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._mapPoints3203, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _mapVectors3204;
		public virtual void mapVectors(float[] arg0, int arg1, float[] arg2, int arg3, int arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Matrix._mapVectors3204, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._mapVectors3204, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _mapVectors3205;
		public virtual void mapVectors(float[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Matrix._mapVectors3205, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._mapVectors3205, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _mapVectors3206;
		public virtual void mapVectors(float[] arg0, float[] arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Matrix._mapVectors3206, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._mapVectors3206, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _mapRect3207;
		public virtual bool mapRect(android.graphics.RectF arg0, android.graphics.RectF arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Matrix._mapRect3207, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._mapRect3207, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _mapRect3208;
		public virtual bool mapRect(android.graphics.RectF arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Matrix._mapRect3208, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._mapRect3208, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _mapRadius3209;
		public virtual float mapRadius(float arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.graphics.Matrix._mapRadius3209, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._mapRadius3209, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setValues3210;
		public virtual void setValues(float[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Matrix._setValues3210, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._setValues3210, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Matrix3211;
		public Matrix()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.Matrix.staticClass, global::android.graphics.Matrix._Matrix3211, this);
		}
		internal static global::net.sf.jni4net.jni.MethodId _Matrix3212;
		public Matrix(android.graphics.Matrix arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.Matrix.staticClass, global::android.graphics.Matrix._Matrix3212, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.graphics.Matrix.staticClass = @__class;
			global::android.graphics.Matrix._equals3164 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.graphics.Matrix._toString3165 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "toString", "()Ljava/lang/String;");
			global::android.graphics.Matrix._set3166 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "set", "(Landroid/graphics/Matrix;)V");
			global::android.graphics.Matrix._reset3167 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "reset", "()V");
			global::android.graphics.Matrix._toShortString3168 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "toShortString", "()Ljava/lang/String;");
			global::android.graphics.Matrix._getValues3169 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "getValues", "([F)V");
			global::android.graphics.Matrix._isIdentity3170 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "isIdentity", "()Z");
			global::android.graphics.Matrix._rectStaysRect3171 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "rectStaysRect", "()Z");
			global::android.graphics.Matrix._setTranslate3172 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "setTranslate", "(FF)V");
			global::android.graphics.Matrix._setScale3173 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "setScale", "(FF)V");
			global::android.graphics.Matrix._setScale3174 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "setScale", "(FFFF)V");
			global::android.graphics.Matrix._setRotate3175 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "setRotate", "(FFF)V");
			global::android.graphics.Matrix._setRotate3176 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "setRotate", "(F)V");
			global::android.graphics.Matrix._setSinCos3177 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "setSinCos", "(FFFF)V");
			global::android.graphics.Matrix._setSinCos3178 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "setSinCos", "(FF)V");
			global::android.graphics.Matrix._setSkew3179 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "setSkew", "(FFFF)V");
			global::android.graphics.Matrix._setSkew3180 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "setSkew", "(FF)V");
			global::android.graphics.Matrix._setConcat3181 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "setConcat", "(Landroid/graphics/Matrix;Landroid/graphics/Matrix;)Z");
			global::android.graphics.Matrix._preTranslate3182 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "preTranslate", "(FF)Z");
			global::android.graphics.Matrix._preScale3183 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "preScale", "(FFFF)Z");
			global::android.graphics.Matrix._preScale3184 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "preScale", "(FF)Z");
			global::android.graphics.Matrix._preRotate3185 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "preRotate", "(FFF)Z");
			global::android.graphics.Matrix._preRotate3186 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "preRotate", "(F)Z");
			global::android.graphics.Matrix._preSkew3187 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "preSkew", "(FF)Z");
			global::android.graphics.Matrix._preSkew3188 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "preSkew", "(FFFF)Z");
			global::android.graphics.Matrix._preConcat3189 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "preConcat", "(Landroid/graphics/Matrix;)Z");
			global::android.graphics.Matrix._postTranslate3190 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "postTranslate", "(FF)Z");
			global::android.graphics.Matrix._postScale3191 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "postScale", "(FFFF)Z");
			global::android.graphics.Matrix._postScale3192 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "postScale", "(FF)Z");
			global::android.graphics.Matrix._postRotate3193 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "postRotate", "(FFF)Z");
			global::android.graphics.Matrix._postRotate3194 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "postRotate", "(F)Z");
			global::android.graphics.Matrix._postSkew3195 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "postSkew", "(FFFF)Z");
			global::android.graphics.Matrix._postSkew3196 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "postSkew", "(FF)Z");
			global::android.graphics.Matrix._postConcat3197 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "postConcat", "(Landroid/graphics/Matrix;)Z");
			global::android.graphics.Matrix._setRectToRect3198 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "setRectToRect", "(Landroid/graphics/RectF;Landroid/graphics/RectF;Landroid/graphics/Matrix$ScaleToFit;)Z");
			global::android.graphics.Matrix._setPolyToPoly3199 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "setPolyToPoly", "([FI[FII)Z");
			global::android.graphics.Matrix._invert3200 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "invert", "(Landroid/graphics/Matrix;)Z");
			global::android.graphics.Matrix._mapPoints3201 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "mapPoints", "([FI[FII)V");
			global::android.graphics.Matrix._mapPoints3202 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "mapPoints", "([F[F)V");
			global::android.graphics.Matrix._mapPoints3203 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "mapPoints", "([F)V");
			global::android.graphics.Matrix._mapVectors3204 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "mapVectors", "([FI[FII)V");
			global::android.graphics.Matrix._mapVectors3205 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "mapVectors", "([F)V");
			global::android.graphics.Matrix._mapVectors3206 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "mapVectors", "([F[F)V");
			global::android.graphics.Matrix._mapRect3207 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "mapRect", "(Landroid/graphics/RectF;Landroid/graphics/RectF;)Z");
			global::android.graphics.Matrix._mapRect3208 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "mapRect", "(Landroid/graphics/RectF;)Z");
			global::android.graphics.Matrix._mapRadius3209 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "mapRadius", "(F)F");
			global::android.graphics.Matrix._setValues3210 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "setValues", "([F)V");
			global::android.graphics.Matrix._Matrix3211 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "<init>", "()V");
			global::android.graphics.Matrix._Matrix3212 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "<init>", "(Landroid/graphics/Matrix;)V");
		}
	}
}
