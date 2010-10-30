namespace javax.xml.validation
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.xml.validation.TypeInfoProvider_))]
	public abstract partial class TypeInfoProvider : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TypeInfoProvider(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getElementTypeInfo31212;
		public abstract global::org.w3c.dom.TypeInfo getElementTypeInfo();
		internal static global::MonoJavaBridge.MethodId _getAttributeTypeInfo31213;
		public abstract global::org.w3c.dom.TypeInfo getAttributeTypeInfo(int arg0);
		internal static global::MonoJavaBridge.MethodId _isIdAttribute31214;
		public abstract bool isIdAttribute(int arg0);
		internal static global::MonoJavaBridge.MethodId _isSpecified31215;
		public abstract bool isSpecified(int arg0);
		internal static global::MonoJavaBridge.MethodId _TypeInfoProvider31216;
		protected TypeInfoProvider() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.validation.TypeInfoProvider._TypeInfoProvider31216.native == global::System.IntPtr.Zero)
				global::javax.xml.validation.TypeInfoProvider._TypeInfoProvider31216 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.TypeInfoProvider.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.validation.TypeInfoProvider.staticClass, global::javax.xml.validation.TypeInfoProvider._TypeInfoProvider31216);
			Init(@__env, handle);
		}
		static TypeInfoProvider()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.validation.TypeInfoProvider.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/validation/TypeInfoProvider"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.validation.TypeInfoProvider))]
	internal sealed partial class TypeInfoProvider_ : javax.xml.validation.TypeInfoProvider
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal TypeInfoProvider_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getElementTypeInfo31217;
		public override global::org.w3c.dom.TypeInfo getElementTypeInfo()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.validation.TypeInfoProvider_._getElementTypeInfo31217.native == global::System.IntPtr.Zero)
				global::javax.xml.validation.TypeInfoProvider_._getElementTypeInfo31217 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.TypeInfoProvider_.staticClass, "getElementTypeInfo", "()Lorg/w3c/dom/TypeInfo;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.TypeInfo>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.validation.TypeInfoProvider_._getElementTypeInfo31217)) as org.w3c.dom.TypeInfo;
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeTypeInfo31218;
		public override global::org.w3c.dom.TypeInfo getAttributeTypeInfo(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.validation.TypeInfoProvider_._getAttributeTypeInfo31218.native == global::System.IntPtr.Zero)
				global::javax.xml.validation.TypeInfoProvider_._getAttributeTypeInfo31218 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.TypeInfoProvider_.staticClass, "getAttributeTypeInfo", "(I)Lorg/w3c/dom/TypeInfo;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.TypeInfo>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.validation.TypeInfoProvider_._getAttributeTypeInfo31218, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.TypeInfo;
		}
		internal static global::MonoJavaBridge.MethodId _isIdAttribute31219;
		public override bool isIdAttribute(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.validation.TypeInfoProvider_._isIdAttribute31219.native == global::System.IntPtr.Zero)
				global::javax.xml.validation.TypeInfoProvider_._isIdAttribute31219 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.TypeInfoProvider_.staticClass, "isIdAttribute", "(I)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.validation.TypeInfoProvider_._isIdAttribute31219, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSpecified31220;
		public override bool isSpecified(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.validation.TypeInfoProvider_._isSpecified31220.native == global::System.IntPtr.Zero)
				global::javax.xml.validation.TypeInfoProvider_._isSpecified31220 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.TypeInfoProvider_.staticClass, "isSpecified", "(I)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.validation.TypeInfoProvider_._isSpecified31220, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static TypeInfoProvider_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.validation.TypeInfoProvider_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/validation/TypeInfoProvider"));
		}
		internal static void InitJNI()
		{
		}
	}
}
