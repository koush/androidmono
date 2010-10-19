namespace javax.crypto.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PBEKeySpec : java.lang.Object, java.security.spec.KeySpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PBEKeySpec()
		{
			InitJNI();
		}
		protected PBEKeySpec(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new char[] Password
		{
			get
			{
				return getPassword();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPassword22771;
		public virtual char[] getPassword() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.spec.PBEKeySpec._getPassword22771)) as char[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.spec.PBEKeySpec.staticClass, global::javax.crypto.spec.PBEKeySpec._getPassword22771)) as char[];
		}
		internal static global::MonoJavaBridge.MethodId _clearPassword22772;
		public virtual void clearPassword() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.spec.PBEKeySpec._clearPassword22772);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.spec.PBEKeySpec.staticClass, global::javax.crypto.spec.PBEKeySpec._clearPassword22772);
		}
		public new int IterationCount
		{
			get
			{
				return getIterationCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIterationCount22773;
		public virtual int getIterationCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.spec.PBEKeySpec._getIterationCount22773);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.crypto.spec.PBEKeySpec.staticClass, global::javax.crypto.spec.PBEKeySpec._getIterationCount22773);
		}
		public new byte[] Salt
		{
			get
			{
				return getSalt();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSalt22774;
		public virtual byte[] getSalt() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.spec.PBEKeySpec._getSalt22774)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.spec.PBEKeySpec.staticClass, global::javax.crypto.spec.PBEKeySpec._getSalt22774)) as byte[];
		}
		public new int KeyLength
		{
			get
			{
				return getKeyLength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getKeyLength22775;
		public virtual int getKeyLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.spec.PBEKeySpec._getKeyLength22775);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.crypto.spec.PBEKeySpec.staticClass, global::javax.crypto.spec.PBEKeySpec._getKeyLength22775);
		}
		internal static global::MonoJavaBridge.MethodId _PBEKeySpec22776;
		public PBEKeySpec(char[] arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.spec.PBEKeySpec.staticClass, global::javax.crypto.spec.PBEKeySpec._PBEKeySpec22776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PBEKeySpec22777;
		public PBEKeySpec(char[] arg0, byte[] arg1, int arg2, int arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.spec.PBEKeySpec.staticClass, global::javax.crypto.spec.PBEKeySpec._PBEKeySpec22777, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PBEKeySpec22778;
		public PBEKeySpec(char[] arg0, byte[] arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.spec.PBEKeySpec.staticClass, global::javax.crypto.spec.PBEKeySpec._PBEKeySpec22778, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.spec.PBEKeySpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/spec/PBEKeySpec"));
			global::javax.crypto.spec.PBEKeySpec._getPassword22771 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.PBEKeySpec.staticClass, "getPassword", "()[C");
			global::javax.crypto.spec.PBEKeySpec._clearPassword22772 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.PBEKeySpec.staticClass, "clearPassword", "()V");
			global::javax.crypto.spec.PBEKeySpec._getIterationCount22773 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.PBEKeySpec.staticClass, "getIterationCount", "()I");
			global::javax.crypto.spec.PBEKeySpec._getSalt22774 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.PBEKeySpec.staticClass, "getSalt", "()[B");
			global::javax.crypto.spec.PBEKeySpec._getKeyLength22775 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.PBEKeySpec.staticClass, "getKeyLength", "()I");
			global::javax.crypto.spec.PBEKeySpec._PBEKeySpec22776 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.PBEKeySpec.staticClass, "<init>", "([C)V");
			global::javax.crypto.spec.PBEKeySpec._PBEKeySpec22777 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.PBEKeySpec.staticClass, "<init>", "([C[BII)V");
			global::javax.crypto.spec.PBEKeySpec._PBEKeySpec22778 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.PBEKeySpec.staticClass, "<init>", "([C[BI)V");
		}
	}
}
