namespace javax.xml.validation
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.xml.validation.SchemaFactoryLoader_))]
	public abstract partial class SchemaFactoryLoader : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SchemaFactoryLoader()
		{
			InitJNI();
		}
		protected SchemaFactoryLoader(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _newFactory31208;
		public abstract global::javax.xml.validation.SchemaFactory newFactory(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _SchemaFactoryLoader31209;
		protected SchemaFactoryLoader()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.validation.SchemaFactoryLoader.staticClass, global::javax.xml.validation.SchemaFactoryLoader._SchemaFactoryLoader31209);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.validation.SchemaFactoryLoader.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/validation/SchemaFactoryLoader"));
			global::javax.xml.validation.SchemaFactoryLoader._newFactory31208 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.SchemaFactoryLoader.staticClass, "newFactory", "(Ljava/lang/String;)Ljavax/xml/validation/SchemaFactory;");
			global::javax.xml.validation.SchemaFactoryLoader._SchemaFactoryLoader31209 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.SchemaFactoryLoader.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.validation.SchemaFactoryLoader))]
	internal sealed partial class SchemaFactoryLoader_ : javax.xml.validation.SchemaFactoryLoader
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SchemaFactoryLoader_()
		{
			InitJNI();
		}
		internal SchemaFactoryLoader_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _newFactory31210;
		public override global::javax.xml.validation.SchemaFactory newFactory(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.validation.SchemaFactoryLoader_._newFactory31210, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.validation.SchemaFactory;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.validation.SchemaFactoryLoader_.staticClass, global::javax.xml.validation.SchemaFactoryLoader_._newFactory31210, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.validation.SchemaFactory;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.validation.SchemaFactoryLoader_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/validation/SchemaFactoryLoader"));
			global::javax.xml.validation.SchemaFactoryLoader_._newFactory31210 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.SchemaFactoryLoader_.staticClass, "newFactory", "(Ljava/lang/String;)Ljavax/xml/validation/SchemaFactory;");
		}
	}
}
