namespace javax.xml.validation
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.xml.validation.TypeInfoProvider_))]
	public abstract partial class TypeInfoProvider : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TypeInfoProvider(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract global::org.w3c.dom.TypeInfo getElementTypeInfo();
		private static global::MonoJavaBridge.MethodId _m1;
		public abstract global::org.w3c.dom.TypeInfo getAttributeTypeInfo(int arg0);
		private static global::MonoJavaBridge.MethodId _m2;
		public abstract bool isIdAttribute(int arg0);
		private static global::MonoJavaBridge.MethodId _m3;
		public abstract bool isSpecified(int arg0);
		private static global::MonoJavaBridge.MethodId _m4;
		protected TypeInfoProvider() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.validation.TypeInfoProvider._m4.native == global::System.IntPtr.Zero)
				global::javax.xml.validation.TypeInfoProvider._m4 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.TypeInfoProvider.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.validation.TypeInfoProvider.staticClass, global::javax.xml.validation.TypeInfoProvider._m4);
			Init(@__env, handle);
		}
		static TypeInfoProvider()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.validation.TypeInfoProvider.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/validation/TypeInfoProvider"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.validation.TypeInfoProvider))]
	internal sealed partial class TypeInfoProvider_ : javax.xml.validation.TypeInfoProvider
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal TypeInfoProvider_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::org.w3c.dom.TypeInfo getElementTypeInfo()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.TypeInfo>(this, global::javax.xml.validation.TypeInfoProvider_.staticClass, "getElementTypeInfo", "()Lorg/w3c/dom/TypeInfo;", ref global::javax.xml.validation.TypeInfoProvider_._m0) as org.w3c.dom.TypeInfo;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::org.w3c.dom.TypeInfo getAttributeTypeInfo(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.TypeInfo>(this, global::javax.xml.validation.TypeInfoProvider_.staticClass, "getAttributeTypeInfo", "(I)Lorg/w3c/dom/TypeInfo;", ref global::javax.xml.validation.TypeInfoProvider_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.w3c.dom.TypeInfo;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override bool isIdAttribute(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.xml.validation.TypeInfoProvider_.staticClass, "isIdAttribute", "(I)Z", ref global::javax.xml.validation.TypeInfoProvider_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override bool isSpecified(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.xml.validation.TypeInfoProvider_.staticClass, "isSpecified", "(I)Z", ref global::javax.xml.validation.TypeInfoProvider_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static TypeInfoProvider_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.validation.TypeInfoProvider_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/validation/TypeInfoProvider"));
		}
	}
}
