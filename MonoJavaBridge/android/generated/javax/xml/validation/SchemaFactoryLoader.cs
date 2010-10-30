namespace javax.xml.validation
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.xml.validation.SchemaFactoryLoader_))]
	public abstract partial class SchemaFactoryLoader : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SchemaFactoryLoader(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _newFactory31209;
		public abstract global::javax.xml.validation.SchemaFactory newFactory(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _SchemaFactoryLoader31210;
		protected SchemaFactoryLoader() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.validation.SchemaFactoryLoader._SchemaFactoryLoader31210.native == global::System.IntPtr.Zero)
				global::javax.xml.validation.SchemaFactoryLoader._SchemaFactoryLoader31210 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.SchemaFactoryLoader.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.validation.SchemaFactoryLoader.staticClass, global::javax.xml.validation.SchemaFactoryLoader._SchemaFactoryLoader31210);
			Init(@__env, handle);
		}
		static SchemaFactoryLoader()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.validation.SchemaFactoryLoader.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/validation/SchemaFactoryLoader"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.validation.SchemaFactoryLoader))]
	internal sealed partial class SchemaFactoryLoader_ : javax.xml.validation.SchemaFactoryLoader
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SchemaFactoryLoader_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _newFactory31211;
		public override global::javax.xml.validation.SchemaFactory newFactory(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.validation.SchemaFactoryLoader_.staticClass, "newFactory", "(Ljava/lang/String;)Ljavax/xml/validation/SchemaFactory;", ref global::javax.xml.validation.SchemaFactoryLoader_._newFactory31211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as javax.xml.validation.SchemaFactory;
		}
		static SchemaFactoryLoader_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.validation.SchemaFactoryLoader_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/validation/SchemaFactoryLoader"));
		}
		internal static void InitJNI()
		{
		}
	}
}
