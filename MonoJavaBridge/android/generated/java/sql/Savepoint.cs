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
		internal Savepoint_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		int java.sql.Savepoint.getSavepointId()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.Savepoint_.staticClass, "getSavepointId", "()I", ref global::java.sql.Savepoint_._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::java.lang.String java.sql.Savepoint.getSavepointName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.sql.Savepoint_.staticClass, "getSavepointName", "()Ljava/lang/String;", ref global::java.sql.Savepoint_._m1) as java.lang.String;
		}
		static Savepoint_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.Savepoint_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/Savepoint"));
		}
	}
}
