namespace javax.crypto.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PSource : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PSource(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class PSpecified : javax.crypto.spec.PSource
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal PSpecified(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			public new byte[] Value
			{
				get
				{
					return getValue();
				}
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public byte[] getValue()
			{
				return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::javax.crypto.spec.PSource.PSpecified.staticClass, "getValue", "()[B", ref global::javax.crypto.spec.PSource.PSpecified._m0) as byte[];
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public PSpecified(byte[] arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::javax.crypto.spec.PSource.PSpecified._m1.native == global::System.IntPtr.Zero)
					global::javax.crypto.spec.PSource.PSpecified._m1 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.PSource.PSpecified.staticClass, "<init>", "([B)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.spec.PSource.PSpecified.staticClass, global::javax.crypto.spec.PSource.PSpecified._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _DEFAULT6727;
			public static global::javax.crypto.spec.PSource.PSpecified DEFAULT
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.crypto.spec.PSource.PSpecified>(@__env.GetStaticObjectField(global::javax.crypto.spec.PSource.PSpecified.staticClass, _DEFAULT6727)) as javax.crypto.spec.PSource.PSpecified;
				}
			}
			static PSpecified()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::javax.crypto.spec.PSource.PSpecified.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/spec/PSource$PSpecified"));
				global::javax.crypto.spec.PSource.PSpecified._DEFAULT6727 = @__env.GetStaticFieldIDNoThrow(global::javax.crypto.spec.PSource.PSpecified.staticClass, "DEFAULT", "Ljavax/crypto/spec/PSource$PSpecified;");
			}
			internal static void InitJNI()
			{
			}
		}
		public new global::java.lang.String Algorithm
		{
			get
			{
				return getAlgorithm();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.String getAlgorithm()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.crypto.spec.PSource.staticClass, "getAlgorithm", "()Ljava/lang/String;", ref global::javax.crypto.spec.PSource._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected PSource(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.spec.PSource._m1.native == global::System.IntPtr.Zero)
				global::javax.crypto.spec.PSource._m1 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.PSource.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.spec.PSource.staticClass, global::javax.crypto.spec.PSource._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static PSource()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.spec.PSource.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/spec/PSource"));
		}
		internal static void InitJNI()
		{
		}
	}
}
