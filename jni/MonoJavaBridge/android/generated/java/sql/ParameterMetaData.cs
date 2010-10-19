namespace java.sql
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.sql.ParameterMetaData_))]
	public interface ParameterMetaData  : global::MonoJavaBridge.IJavaObject 
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
	public sealed partial class ParameterMetaData_ : java.lang.Object, ParameterMetaData
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ParameterMetaData_()
		{
			InitJNI();
		}
		internal ParameterMetaData_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getScale18852;
		 int java.sql.ParameterMetaData.getScale(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.ParameterMetaData_._getScale18852, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.ParameterMetaData_.staticClass, global::java.sql.ParameterMetaData_._getScale18852, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPrecision18853;
		 int java.sql.ParameterMetaData.getPrecision(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.ParameterMetaData_._getPrecision18853, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.ParameterMetaData_.staticClass, global::java.sql.ParameterMetaData_._getPrecision18853, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isNullable18854;
		 int java.sql.ParameterMetaData.isNullable(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.ParameterMetaData_._isNullable18854, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.ParameterMetaData_.staticClass, global::java.sql.ParameterMetaData_._isNullable18854, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSigned18855;
		 bool java.sql.ParameterMetaData.isSigned(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.ParameterMetaData_._isSigned18855, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.ParameterMetaData_.staticClass, global::java.sql.ParameterMetaData_._isSigned18855, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getParameterCount18856;
		 int java.sql.ParameterMetaData.getParameterCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.ParameterMetaData_._getParameterCount18856);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.ParameterMetaData_.staticClass, global::java.sql.ParameterMetaData_._getParameterCount18856);
		}
		internal static global::MonoJavaBridge.MethodId _getParameterType18857;
		 int java.sql.ParameterMetaData.getParameterType(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.ParameterMetaData_._getParameterType18857, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.ParameterMetaData_.staticClass, global::java.sql.ParameterMetaData_._getParameterType18857, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getParameterTypeName18858;
		 global::java.lang.String java.sql.ParameterMetaData.getParameterTypeName(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ParameterMetaData_._getParameterTypeName18858, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.ParameterMetaData_.staticClass, global::java.sql.ParameterMetaData_._getParameterTypeName18858, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getParameterClassName18859;
		 global::java.lang.String java.sql.ParameterMetaData.getParameterClassName(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ParameterMetaData_._getParameterClassName18859, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.ParameterMetaData_.staticClass, global::java.sql.ParameterMetaData_._getParameterClassName18859, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getParameterMode18860;
		 int java.sql.ParameterMetaData.getParameterMode(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.ParameterMetaData_._getParameterMode18860, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.ParameterMetaData_.staticClass, global::java.sql.ParameterMetaData_._getParameterMode18860, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.ParameterMetaData_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/ParameterMetaData"));
			global::java.sql.ParameterMetaData_._getScale18852 = @__env.GetMethodIDNoThrow(global::java.sql.ParameterMetaData_.staticClass, "getScale", "(I)I");
			global::java.sql.ParameterMetaData_._getPrecision18853 = @__env.GetMethodIDNoThrow(global::java.sql.ParameterMetaData_.staticClass, "getPrecision", "(I)I");
			global::java.sql.ParameterMetaData_._isNullable18854 = @__env.GetMethodIDNoThrow(global::java.sql.ParameterMetaData_.staticClass, "isNullable", "(I)I");
			global::java.sql.ParameterMetaData_._isSigned18855 = @__env.GetMethodIDNoThrow(global::java.sql.ParameterMetaData_.staticClass, "isSigned", "(I)Z");
			global::java.sql.ParameterMetaData_._getParameterCount18856 = @__env.GetMethodIDNoThrow(global::java.sql.ParameterMetaData_.staticClass, "getParameterCount", "()I");
			global::java.sql.ParameterMetaData_._getParameterType18857 = @__env.GetMethodIDNoThrow(global::java.sql.ParameterMetaData_.staticClass, "getParameterType", "(I)I");
			global::java.sql.ParameterMetaData_._getParameterTypeName18858 = @__env.GetMethodIDNoThrow(global::java.sql.ParameterMetaData_.staticClass, "getParameterTypeName", "(I)Ljava/lang/String;");
			global::java.sql.ParameterMetaData_._getParameterClassName18859 = @__env.GetMethodIDNoThrow(global::java.sql.ParameterMetaData_.staticClass, "getParameterClassName", "(I)Ljava/lang/String;");
			global::java.sql.ParameterMetaData_._getParameterMode18860 = @__env.GetMethodIDNoThrow(global::java.sql.ParameterMetaData_.staticClass, "getParameterMode", "(I)I");
		}
	}
}
