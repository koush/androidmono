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
			internal static global::MonoJavaBridge.MethodId _getValue28803;
			public byte[] getValue()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.spec.PSource.PSpecified._getValue28803)) as byte[];
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.spec.PSource.PSpecified.staticClass, global::javax.crypto.spec.PSource.PSpecified._getValue28803)) as byte[];
			}
			internal static global::MonoJavaBridge.MethodId _PSpecified28804;
			public PSpecified(byte[] arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.spec.PSource.PSpecified.staticClass, global::javax.crypto.spec.PSource.PSpecified._PSpecified28804, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _DEFAULT28805;
			public static global::javax.crypto.spec.PSource.PSpecified DEFAULT
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.crypto.spec.PSource.PSpecified>(@__env.GetStaticObjectField(global::javax.crypto.spec.PSource.PSpecified.staticClass, _DEFAULT28805)) as javax.crypto.spec.PSource.PSpecified;
				}
			}
			static PSpecified()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::javax.crypto.spec.PSource.PSpecified.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/spec/PSource$PSpecified"));
				global::javax.crypto.spec.PSource.PSpecified._getValue28803 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.PSource.PSpecified.staticClass, "getValue", "()[B");
				global::javax.crypto.spec.PSource.PSpecified._PSpecified28804 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.PSource.PSpecified.staticClass, "<init>", "([B)V");
				global::javax.crypto.spec.PSource.PSpecified._DEFAULT28805 = @__env.GetStaticFieldIDNoThrow(global::javax.crypto.spec.PSource.PSpecified.staticClass, "DEFAULT", "Ljavax/crypto/spec/PSource$PSpecified;");
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
		internal static global::MonoJavaBridge.MethodId _getAlgorithm28806;
		public virtual global::java.lang.String getAlgorithm()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.spec.PSource._getAlgorithm28806)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.spec.PSource.staticClass, global::javax.crypto.spec.PSource._getAlgorithm28806)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _PSource28807;
		protected PSource(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.spec.PSource.staticClass, global::javax.crypto.spec.PSource._PSource28807, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static PSource()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.spec.PSource.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/spec/PSource"));
			global::javax.crypto.spec.PSource._getAlgorithm28806 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.PSource.staticClass, "getAlgorithm", "()Ljava/lang/String;");
			global::javax.crypto.spec.PSource._PSource28807 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.PSource.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
