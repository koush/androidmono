namespace javax.xml.validation
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.xml.validation.SchemaFactoryLoader_))]
	public abstract partial class SchemaFactoryLoader : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SchemaFactoryLoader(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract global::javax.xml.validation.SchemaFactory newFactory(java.lang.String arg0);
		private static global::MonoJavaBridge.MethodId _m1;
		protected SchemaFactoryLoader() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.validation.SchemaFactoryLoader._m1.native == global::System.IntPtr.Zero)
				global::javax.xml.validation.SchemaFactoryLoader._m1 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.SchemaFactoryLoader.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.validation.SchemaFactoryLoader.staticClass, global::javax.xml.validation.SchemaFactoryLoader._m1);
			Init(@__env, handle);
		}
		static SchemaFactoryLoader()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.validation.SchemaFactoryLoader.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/validation/SchemaFactoryLoader"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.validation.SchemaFactoryLoader))]
	internal sealed partial class SchemaFactoryLoader_ : javax.xml.validation.SchemaFactoryLoader
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SchemaFactoryLoader_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::javax.xml.validation.SchemaFactory newFactory(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.validation.SchemaFactoryLoader_.staticClass, "newFactory", "(Ljava/lang/String;)Ljavax/xml/validation/SchemaFactory;", ref global::javax.xml.validation.SchemaFactoryLoader_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as javax.xml.validation.SchemaFactory;
		}
		static SchemaFactoryLoader_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.validation.SchemaFactoryLoader_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/validation/SchemaFactoryLoader"));
		}
	}
}
