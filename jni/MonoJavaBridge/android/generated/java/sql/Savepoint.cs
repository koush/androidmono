namespace java.sql
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.sql.Savepoint_))]
	public partial interface Savepoint  : global::MonoJavaBridge.IJavaObject 
	{
		int getSavepointId();
		global::java.lang.String getSavepointName();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.sql.Savepoint))]
	internal sealed partial class Savepoint_ : java.lang.Object, Savepoint
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Savepoint_()
		{
			InitJNI();
		}
		internal Savepoint_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getSavepointId25043;
		int java.sql.Savepoint.getSavepointId()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Savepoint_._getSavepointId25043);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Savepoint_.staticClass, global::java.sql.Savepoint_._getSavepointId25043);
		}
		internal static global::MonoJavaBridge.MethodId _getSavepointName25044;
		global::java.lang.String java.sql.Savepoint.getSavepointName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Savepoint_._getSavepointName25044)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Savepoint_.staticClass, global::java.sql.Savepoint_._getSavepointName25044)) as java.lang.String;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.Savepoint_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/Savepoint"));
			global::java.sql.Savepoint_._getSavepointId25043 = @__env.GetMethodIDNoThrow(global::java.sql.Savepoint_.staticClass, "getSavepointId", "()I");
			global::java.sql.Savepoint_._getSavepointName25044 = @__env.GetMethodIDNoThrow(global::java.sql.Savepoint_.staticClass, "getSavepointName", "()Ljava/lang/String;");
		}
	}
}
