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
		internal static global::MonoJavaBridge.MethodId _setProperty24617;
		public virtual void setProperty(java.lang.String arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.Validator._setProperty24617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.validation.Validator.staticClass, global::javax.xml.validation.Validator._setProperty24617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getProperty24618;
		public virtual global::java.lang.Object getProperty(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.validation.Validator._getProperty24618, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.validation.Validator.staticClass, global::javax.xml.validation.Validator._getProperty24618, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _reset24619;
		public abstract void reset();
		internal static global::MonoJavaBridge.MethodId _validate24620;
		public abstract void validate(javax.xml.transform.Source arg0, javax.xml.transform.Result arg1);
		internal static global::MonoJavaBridge.MethodId _validate24621;
		public virtual void validate(javax.xml.transform.Source arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.Validator._validate24621, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.validation.Validator.staticClass, global::javax.xml.validation.Validator._validate24621, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFeature24622;
		public virtual void setFeature(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.Validator._setFeature24622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.validation.Validator.staticClass, global::javax.xml.validation.Validator._setFeature24622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFeature24623;
		public virtual bool getFeature(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.validation.Validator._getFeature24623, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.xml.validation.Validator.staticClass, global::javax.xml.validation.Validator._getFeature24623, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setErrorHandler24624;
		public abstract void setErrorHandler(org.xml.sax.ErrorHandler arg0);
		internal static global::MonoJavaBridge.MethodId _getErrorHandler24625;
		public abstract global::org.xml.sax.ErrorHandler getErrorHandler();
		internal static global::MonoJavaBridge.MethodId _setResourceResolver24626;
		public abstract void setResourceResolver(org.w3c.dom.ls.LSResourceResolver arg0);
		internal static global::MonoJavaBridge.MethodId _getResourceResolver24627;
		public abstract global::org.w3c.dom.ls.LSResourceResolver getResourceResolver();
		internal static global::MonoJavaBridge.MethodId _Validator24628;
		protected Validator()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.validation.Validator.staticClass, global::javax.xml.validation.Validator._Validator24628);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.validation.Validator.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/validation/Validator"));
			global::javax.xml.validation.Validator._setProperty24617 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.Validator.staticClass, "setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::javax.xml.validation.Validator._getProperty24618 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.Validator.staticClass, "getProperty", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::javax.xml.validation.Validator._reset24619 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.Validator.staticClass, "reset", "()V");
			global::javax.xml.validation.Validator._validate24620 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.Validator.staticClass, "validate", "(Ljavax/xml/transform/Source;Ljavax/xml/transform/Result;)V");
			global::javax.xml.validation.Validator._validate24621 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.Validator.staticClass, "validate", "(Ljavax/xml/transform/Source;)V");
			global::javax.xml.validation.Validator._setFeature24622 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.Validator.staticClass, "setFeature", "(Ljava/lang/String;Z)V");
			global::javax.xml.validation.Validator._getFeature24623 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.Validator.staticClass, "getFeature", "(Ljava/lang/String;)Z");
			global::javax.xml.validation.Validator._setErrorHandler24624 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.Validator.staticClass, "setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V");
			global::javax.xml.validation.Validator._getErrorHandler24625 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.Validator.staticClass, "getErrorHandler", "()Lorg/xml/sax/ErrorHandler;");
			global::javax.xml.validation.Validator._setResourceResolver24626 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.Validator.staticClass, "setResourceResolver", "(Lorg/w3c/dom/ls/LSResourceResolver;)V");
			global::javax.xml.validation.Validator._getResourceResolver24627 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.Validator.staticClass, "getResourceResolver", "()Lorg/w3c/dom/ls/LSResourceResolver;");
			global::javax.xml.validation.Validator._Validator24628 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.Validator.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.validation.Validator))]
	public sealed partial class Validator_ : javax.xml.validation.Validator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Validator_()
		{
			InitJNI();
		}
		internal Validator_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _reset24629;
		public override void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.Validator_._reset24629);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.validation.Validator_.staticClass, global::javax.xml.validation.Validator_._reset24629);
		}
		internal static global::MonoJavaBridge.MethodId _validate24630;
		public override void validate(javax.xml.transform.Source arg0, javax.xml.transform.Result arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.Validator_._validate24630, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.validation.Validator_.staticClass, global::javax.xml.validation.Validator_._validate24630, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setErrorHandler24631;
		public override void setErrorHandler(org.xml.sax.ErrorHandler arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.Validator_._setErrorHandler24631, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.validation.Validator_.staticClass, global::javax.xml.validation.Validator_._setErrorHandler24631, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getErrorHandler24632;
		public override global::org.xml.sax.ErrorHandler getErrorHandler() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.ErrorHandler>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.validation.Validator_._getErrorHandler24632)) as org.xml.sax.ErrorHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.ErrorHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.validation.Validator_.staticClass, global::javax.xml.validation.Validator_._getErrorHandler24632)) as org.xml.sax.ErrorHandler;
		}
		internal static global::MonoJavaBridge.MethodId _setResourceResolver24633;
		public override void setResourceResolver(org.w3c.dom.ls.LSResourceResolver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.validation.Validator_._setResourceResolver24633, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.validation.Validator_.staticClass, global::javax.xml.validation.Validator_._setResourceResolver24633, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getResourceResolver24634;
		public override global::org.w3c.dom.ls.LSResourceResolver getResourceResolver() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.ls.LSResourceResolver>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.validation.Validator_._getResourceResolver24634)) as org.w3c.dom.ls.LSResourceResolver;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.ls.LSResourceResolver>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.validation.Validator_.staticClass, global::javax.xml.validation.Validator_._getResourceResolver24634)) as org.w3c.dom.ls.LSResourceResolver;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.validation.Validator_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/validation/Validator"));
			global::javax.xml.validation.Validator_._reset24629 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.Validator_.staticClass, "reset", "()V");
			global::javax.xml.validation.Validator_._validate24630 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.Validator_.staticClass, "validate", "(Ljavax/xml/transform/Source;Ljavax/xml/transform/Result;)V");
			global::javax.xml.validation.Validator_._setErrorHandler24631 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.Validator_.staticClass, "setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V");
			global::javax.xml.validation.Validator_._getErrorHandler24632 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.Validator_.staticClass, "getErrorHandler", "()Lorg/xml/sax/ErrorHandler;");
			global::javax.xml.validation.Validator_._setResourceResolver24633 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.Validator_.staticClass, "setResourceResolver", "(Lorg/w3c/dom/ls/LSResourceResolver;)V");
			global::javax.xml.validation.Validator_._getResourceResolver24634 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.Validator_.staticClass, "getResourceResolver", "()Lorg/w3c/dom/ls/LSResourceResolver;");
		}
	}
}
