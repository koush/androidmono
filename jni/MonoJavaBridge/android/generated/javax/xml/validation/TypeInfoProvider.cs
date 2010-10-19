namespace javax.xml.validation
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.xml.validation.TypeInfoProvider_))]
	public abstract partial class TypeInfoProvider : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TypeInfoProvider()
		{
			InitJNI();
		}
		protected TypeInfoProvider(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getElementTypeInfo24608;
		public abstract global::org.w3c.dom.TypeInfo getElementTypeInfo();
		internal static global::MonoJavaBridge.MethodId _getAttributeTypeInfo24609;
		public abstract global::org.w3c.dom.TypeInfo getAttributeTypeInfo(int arg0);
		internal static global::MonoJavaBridge.MethodId _isIdAttribute24610;
		public abstract bool isIdAttribute(int arg0);
		internal static global::MonoJavaBridge.MethodId _isSpecified24611;
		public abstract bool isSpecified(int arg0);
		internal static global::MonoJavaBridge.MethodId _TypeInfoProvider24612;
		protected TypeInfoProvider()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.validation.TypeInfoProvider.staticClass, global::javax.xml.validation.TypeInfoProvider._TypeInfoProvider24612);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.validation.TypeInfoProvider.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/validation/TypeInfoProvider"));
			global::javax.xml.validation.TypeInfoProvider._getElementTypeInfo24608 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.TypeInfoProvider.staticClass, "getElementTypeInfo", "()Lorg/w3c/dom/TypeInfo;");
			global::javax.xml.validation.TypeInfoProvider._getAttributeTypeInfo24609 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.TypeInfoProvider.staticClass, "getAttributeTypeInfo", "(I)Lorg/w3c/dom/TypeInfo;");
			global::javax.xml.validation.TypeInfoProvider._isIdAttribute24610 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.TypeInfoProvider.staticClass, "isIdAttribute", "(I)Z");
			global::javax.xml.validation.TypeInfoProvider._isSpecified24611 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.TypeInfoProvider.staticClass, "isSpecified", "(I)Z");
			global::javax.xml.validation.TypeInfoProvider._TypeInfoProvider24612 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.TypeInfoProvider.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.validation.TypeInfoProvider))]
	public sealed partial class TypeInfoProvider_ : javax.xml.validation.TypeInfoProvider
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TypeInfoProvider_()
		{
			InitJNI();
		}
		internal TypeInfoProvider_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getElementTypeInfo24613;
		public override global::org.w3c.dom.TypeInfo getElementTypeInfo() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.TypeInfo>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.validation.TypeInfoProvider_._getElementTypeInfo24613)) as org.w3c.dom.TypeInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.TypeInfo>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.validation.TypeInfoProvider_.staticClass, global::javax.xml.validation.TypeInfoProvider_._getElementTypeInfo24613)) as org.w3c.dom.TypeInfo;
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeTypeInfo24614;
		public override global::org.w3c.dom.TypeInfo getAttributeTypeInfo(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.TypeInfo>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.validation.TypeInfoProvider_._getAttributeTypeInfo24614, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.TypeInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.TypeInfo>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.validation.TypeInfoProvider_.staticClass, global::javax.xml.validation.TypeInfoProvider_._getAttributeTypeInfo24614, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.TypeInfo;
		}
		internal static global::MonoJavaBridge.MethodId _isIdAttribute24615;
		public override bool isIdAttribute(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.validation.TypeInfoProvider_._isIdAttribute24615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.xml.validation.TypeInfoProvider_.staticClass, global::javax.xml.validation.TypeInfoProvider_._isIdAttribute24615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSpecified24616;
		public override bool isSpecified(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.validation.TypeInfoProvider_._isSpecified24616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.xml.validation.TypeInfoProvider_.staticClass, global::javax.xml.validation.TypeInfoProvider_._isSpecified24616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.validation.TypeInfoProvider_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/validation/TypeInfoProvider"));
			global::javax.xml.validation.TypeInfoProvider_._getElementTypeInfo24613 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.TypeInfoProvider_.staticClass, "getElementTypeInfo", "()Lorg/w3c/dom/TypeInfo;");
			global::javax.xml.validation.TypeInfoProvider_._getAttributeTypeInfo24614 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.TypeInfoProvider_.staticClass, "getAttributeTypeInfo", "(I)Lorg/w3c/dom/TypeInfo;");
			global::javax.xml.validation.TypeInfoProvider_._isIdAttribute24615 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.TypeInfoProvider_.staticClass, "isIdAttribute", "(I)Z");
			global::javax.xml.validation.TypeInfoProvider_._isSpecified24616 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.TypeInfoProvider_.staticClass, "isSpecified", "(I)Z");
		}
	}
}
