namespace javax.xml.validation
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.xml.validation.Validator_))]
	public abstract partial class Validator : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Validator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setProperty31221;
		public virtual void setProperty(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.validation.Validator._setProperty31221.native == global::System.IntPtr.Zero)
				global::javax.xml.validation.Validator._setProperty31221 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.Validator.staticClass, "setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.validation.Validator.staticClass, global::javax.xml.validation.Validator._setProperty31221, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getProperty31222;
		public virtual global::java.lang.Object getProperty(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.validation.Validator._getProperty31222.native == global::System.IntPtr.Zero)
				global::javax.xml.validation.Validator._getProperty31222 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.Validator.staticClass, "getProperty", "(Ljava/lang/String;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.validation.Validator.staticClass, global::javax.xml.validation.Validator._getProperty31222, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _reset31223;
		public abstract void reset();
		internal static global::MonoJavaBridge.MethodId _validate31224;
		public abstract void validate(javax.xml.transform.Source arg0, javax.xml.transform.Result arg1);
		internal static global::MonoJavaBridge.MethodId _validate31225;
		public virtual void validate(javax.xml.transform.Source arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.validation.Validator._validate31225.native == global::System.IntPtr.Zero)
				global::javax.xml.validation.Validator._validate31225 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.Validator.staticClass, "validate", "(Ljavax/xml/transform/Source;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.validation.Validator.staticClass, global::javax.xml.validation.Validator._validate31225, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFeature31226;
		public virtual void setFeature(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.validation.Validator._setFeature31226.native == global::System.IntPtr.Zero)
				global::javax.xml.validation.Validator._setFeature31226 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.Validator.staticClass, "setFeature", "(Ljava/lang/String;Z)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.validation.Validator.staticClass, global::javax.xml.validation.Validator._setFeature31226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFeature31227;
		public virtual bool getFeature(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.validation.Validator._getFeature31227.native == global::System.IntPtr.Zero)
				global::javax.xml.validation.Validator._getFeature31227 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.Validator.staticClass, "getFeature", "(Ljava/lang/String;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.xml.validation.Validator.staticClass, global::javax.xml.validation.Validator._getFeature31227, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setErrorHandler31228;
		public abstract void setErrorHandler(org.xml.sax.ErrorHandler arg0);
		internal static global::MonoJavaBridge.MethodId _getErrorHandler31229;
		public abstract global::org.xml.sax.ErrorHandler getErrorHandler();
		internal static global::MonoJavaBridge.MethodId _setResourceResolver31230;
		public abstract void setResourceResolver(org.w3c.dom.ls.LSResourceResolver arg0);
		internal static global::MonoJavaBridge.MethodId _getResourceResolver31231;
		public abstract global::org.w3c.dom.ls.LSResourceResolver getResourceResolver();
		internal static global::MonoJavaBridge.MethodId _Validator31232;
		protected Validator() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.validation.Validator._Validator31232.native == global::System.IntPtr.Zero)
				global::javax.xml.validation.Validator._Validator31232 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.Validator.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.validation.Validator.staticClass, global::javax.xml.validation.Validator._Validator31232);
			Init(@__env, handle);
		}
		static Validator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.validation.Validator.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/validation/Validator"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.validation.Validator))]
	internal sealed partial class Validator_ : javax.xml.validation.Validator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Validator_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _reset31233;
		public override void reset()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.validation.Validator_._reset31233.native == global::System.IntPtr.Zero)
				global::javax.xml.validation.Validator_._reset31233 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.Validator_.staticClass, "reset", "()V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.Validator_._reset31233);
		}
		internal static global::MonoJavaBridge.MethodId _validate31234;
		public override void validate(javax.xml.transform.Source arg0, javax.xml.transform.Result arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.validation.Validator_._validate31234.native == global::System.IntPtr.Zero)
				global::javax.xml.validation.Validator_._validate31234 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.Validator_.staticClass, "validate", "(Ljavax/xml/transform/Source;Ljavax/xml/transform/Result;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.Validator_._validate31234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setErrorHandler31235;
		public override void setErrorHandler(org.xml.sax.ErrorHandler arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.validation.Validator_._setErrorHandler31235.native == global::System.IntPtr.Zero)
				global::javax.xml.validation.Validator_._setErrorHandler31235 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.Validator_.staticClass, "setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.Validator_._setErrorHandler31235, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getErrorHandler31236;
		public override global::org.xml.sax.ErrorHandler getErrorHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.validation.Validator_._getErrorHandler31236.native == global::System.IntPtr.Zero)
				global::javax.xml.validation.Validator_._getErrorHandler31236 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.Validator_.staticClass, "getErrorHandler", "()Lorg/xml/sax/ErrorHandler;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.ErrorHandler>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.validation.Validator_._getErrorHandler31236)) as org.xml.sax.ErrorHandler;
		}
		internal static global::MonoJavaBridge.MethodId _setResourceResolver31237;
		public override void setResourceResolver(org.w3c.dom.ls.LSResourceResolver arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.validation.Validator_._setResourceResolver31237.native == global::System.IntPtr.Zero)
				global::javax.xml.validation.Validator_._setResourceResolver31237 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.Validator_.staticClass, "setResourceResolver", "(Lorg/w3c/dom/ls/LSResourceResolver;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.Validator_._setResourceResolver31237, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getResourceResolver31238;
		public override global::org.w3c.dom.ls.LSResourceResolver getResourceResolver()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.validation.Validator_._getResourceResolver31238.native == global::System.IntPtr.Zero)
				global::javax.xml.validation.Validator_._getResourceResolver31238 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.Validator_.staticClass, "getResourceResolver", "()Lorg/w3c/dom/ls/LSResourceResolver;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.ls.LSResourceResolver>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.validation.Validator_._getResourceResolver31238)) as org.w3c.dom.ls.LSResourceResolver;
		}
		static Validator_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.validation.Validator_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/validation/Validator"));
		}
		internal static void InitJNI()
		{
		}
	}
}
