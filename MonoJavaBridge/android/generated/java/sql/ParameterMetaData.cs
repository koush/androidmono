namespace java.sql
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.sql.ParameterMetaData_))]
	public partial interface ParameterMetaData  : global::MonoJavaBridge.IJavaObject 
	{
		int getScale(int arg0);
		int getPrecision(int arg0);
		int isNullable(int arg0);
		bool isSigned(int arg0);
		int getParameterCount();
		int getParameterType(int arg0);
		global::java.lang.String getParameterTypeName(int arg0);
		global::java.lang.String getParameterClassName(int arg0);
		int getParameterMode(int arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.sql.ParameterMetaData))]
	internal sealed partial class ParameterMetaData_ : java.lang.Object, ParameterMetaData
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ParameterMetaData_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		int java.sql.ParameterMetaData.getScale(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.ParameterMetaData_.staticClass, "getScale", "(I)I", ref global::java.sql.ParameterMetaData_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		int java.sql.ParameterMetaData.getPrecision(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.ParameterMetaData_.staticClass, "getPrecision", "(I)I", ref global::java.sql.ParameterMetaData_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		int java.sql.ParameterMetaData.isNullable(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.ParameterMetaData_.staticClass, "isNullable", "(I)I", ref global::java.sql.ParameterMetaData_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		bool java.sql.ParameterMetaData.isSigned(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.ParameterMetaData_.staticClass, "isSigned", "(I)Z", ref global::java.sql.ParameterMetaData_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		int java.sql.ParameterMetaData.getParameterCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.ParameterMetaData_.staticClass, "getParameterCount", "()I", ref global::java.sql.ParameterMetaData_._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		int java.sql.ParameterMetaData.getParameterType(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.ParameterMetaData_.staticClass, "getParameterType", "(I)I", ref global::java.sql.ParameterMetaData_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		global::java.lang.String java.sql.ParameterMetaData.getParameterTypeName(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.sql.ParameterMetaData_.staticClass, "getParameterTypeName", "(I)Ljava/lang/String;", ref global::java.sql.ParameterMetaData_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		global::java.lang.String java.sql.ParameterMetaData.getParameterClassName(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.sql.ParameterMetaData_.staticClass, "getParameterClassName", "(I)Ljava/lang/String;", ref global::java.sql.ParameterMetaData_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		int java.sql.ParameterMetaData.getParameterMode(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.ParameterMetaData_.staticClass, "getParameterMode", "(I)I", ref global::java.sql.ParameterMetaData_._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static ParameterMetaData_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.ParameterMetaData_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/ParameterMetaData"));
		}
	}
}
