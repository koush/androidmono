namespace javax.xml.validation
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.xml.validation.Validator_))]
	public abstract partial class Validator : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Validator()
		{
			InitJNI();
		}
		protected Validator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setProperty31220;
		public virtual void setProperty(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.Validator._setProperty31220, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.validation.Validator.staticClass, global::javax.xml.validation.Validator._setProperty31220, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getProperty31221;
		public virtual global::java.lang.Object getProperty(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.validation.Validator._getProperty31221, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.validation.Validator.staticClass, global::javax.xml.validation.Validator._getProperty31221, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _reset31222;
		public abstract void reset();
		internal static global::MonoJavaBridge.MethodId _validate31223;
		public abstract void validate(javax.xml.transform.Source arg0, javax.xml.transform.Result arg1);
		internal static global::MonoJavaBridge.MethodId _validate31224;
		public virtual void validate(javax.xml.transform.Source arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.Validator._validate31224, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.validation.Validator.staticClass, global::javax.xml.validation.Validator._validate31224, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFeature31225;
		public virtual void setFeature(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.Validator._setFeature31225, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.validation.Validator.staticClass, global::javax.xml.validation.Validator._setFeature31225, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFeature31226;
		public virtual bool getFeature(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.validation.Validator._getFeature31226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.xml.validation.Validator.staticClass, global::javax.xml.validation.Validator._getFeature31226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setErrorHandler31227;
		public abstract void setErrorHandler(org.xml.sax.ErrorHandler arg0);
		internal static global::MonoJavaBridge.MethodId _getErrorHandler31228;
		public abstract global::org.xml.sax.ErrorHandler getErrorHandler();
		internal static global::MonoJavaBridge.MethodId _setResourceResolver31229;
		public abstract void setResourceResolver(org.w3c.dom.ls.LSResourceResolver arg0);
		internal static global::MonoJavaBridge.MethodId _getResourceResolver31230;
		public abstract global::org.w3c.dom.ls.LSResourceResolver getResourceResolver();
		internal static global::MonoJavaBridge.MethodId _Validator31231;
		protected Validator() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.validation.Validator.staticClass, global::javax.xml.validation.Validator._Validator31231);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.validation.Validator.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/validation/Validator"));
			global::javax.xml.validation.Validator._setProperty31220 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.Validator.staticClass, "setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::javax.xml.validation.Validator._getProperty31221 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.Validator.staticClass, "getProperty", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::javax.xml.validation.Validator._reset31222 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.Validator.staticClass, "reset", "()V");
			global::javax.xml.validation.Validator._validate31223 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.Validator.staticClass, "validate", "(Ljavax/xml/transform/Source;Ljavax/xml/transform/Result;)V");
			global::javax.xml.validation.Validator._validate31224 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.Validator.staticClass, "validate", "(Ljavax/xml/transform/Source;)V");
			global::javax.xml.validation.Validator._setFeature31225 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.Validator.staticClass, "setFeature", "(Ljava/lang/String;Z)V");
			global::javax.xml.validation.Validator._getFeature31226 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.Validator.staticClass, "getFeature", "(Ljava/lang/String;)Z");
			global::javax.xml.validation.Validator._setErrorHandler31227 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.Validator.staticClass, "setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V");
			global::javax.xml.validation.Validator._getErrorHandler31228 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.Validator.staticClass, "getErrorHandler", "()Lorg/xml/sax/ErrorHandler;");
			global::javax.xml.validation.Validator._setResourceResolver31229 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.Validator.staticClass, "setResourceResolver", "(Lorg/w3c/dom/ls/LSResourceResolver;)V");
			global::javax.xml.validation.Validator._getResourceResolver31230 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.Validator.staticClass, "getResourceResolver", "()Lorg/w3c/dom/ls/LSResourceResolver;");
			global::javax.xml.validation.Validator._Validator31231 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.Validator.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.validation.Validator))]
	internal sealed partial class Validator_ : javax.xml.validation.Validator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Validator_()
		{
			InitJNI();
		}
		internal Validator_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _reset31232;
		public override void reset()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.Validator_._reset31232);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.validation.Validator_.staticClass, global::javax.xml.validation.Validator_._reset31232);
		}
		internal static global::MonoJavaBridge.MethodId _validate31233;
		public override void validate(javax.xml.transform.Source arg0, javax.xml.transform.Result arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.Validator_._validate31233, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.validation.Validator_.staticClass, global::javax.xml.validation.Validator_._validate31233, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setErrorHandler31234;
		public override void setErrorHandler(org.xml.sax.ErrorHandler arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.Validator_._setErrorHandler31234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.validation.Validator_.staticClass, global::javax.xml.validation.Validator_._setErrorHandler31234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getErrorHandler31235;
		public override global::org.xml.sax.ErrorHandler getErrorHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.ErrorHandler>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.validation.Validator_._getErrorHandler31235)) as org.xml.sax.ErrorHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.ErrorHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.validation.Validator_.staticClass, global::javax.xml.validation.Validator_._getErrorHandler31235)) as org.xml.sax.ErrorHandler;
		}
		internal static global::MonoJavaBridge.MethodId _setResourceResolver31236;
		public override void setResourceResolver(org.w3c.dom.ls.LSResourceResolver arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.Validator_._setResourceResolver31236, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.validation.Validator_.staticClass, global::javax.xml.validation.Validator_._setResourceResolver31236, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getResourceResolver31237;
		public override global::org.w3c.dom.ls.LSResourceResolver getResourceResolver()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.ls.LSResourceResolver>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.validation.Validator_._getResourceResolver31237)) as org.w3c.dom.ls.LSResourceResolver;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.ls.LSResourceResolver>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.validation.Validator_.staticClass, global::javax.xml.validation.Validator_._getResourceResolver31237)) as org.w3c.dom.ls.LSResourceResolver;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.validation.Validator_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/validation/Validator"));
			global::javax.xml.validation.Validator_._reset31232 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.Validator_.staticClass, "reset", "()V");
			global::javax.xml.validation.Validator_._validate31233 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.Validator_.staticClass, "validate", "(Ljavax/xml/transform/Source;Ljavax/xml/transform/Result;)V");
			global::javax.xml.validation.Validator_._setErrorHandler31234 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.Validator_.staticClass, "setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V");
			global::javax.xml.validation.Validator_._getErrorHandler31235 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.Validator_.staticClass, "getErrorHandler", "()Lorg/xml/sax/ErrorHandler;");
			global::javax.xml.validation.Validator_._setResourceResolver31236 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.Validator_.staticClass, "setResourceResolver", "(Lorg/w3c/dom/ls/LSResourceResolver;)V");
			global::javax.xml.validation.Validator_._getResourceResolver31237 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.Validator_.staticClass, "getResourceResolver", "()Lorg/w3c/dom/ls/LSResourceResolver;");
		}
	}
}
