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
		internal static global::MonoJavaBridge.MethodId _getScale24527;
		 int java.sql.ParameterMetaData.getScale(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.ParameterMetaData_._getScale24527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.ParameterMetaData_.staticClass, global::java.sql.ParameterMetaData_._getScale24527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPrecision24528;
		 int java.sql.ParameterMetaData.getPrecision(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.ParameterMetaData_._getPrecision24528, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.ParameterMetaData_.staticClass, global::java.sql.ParameterMetaData_._getPrecision24528, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isNullable24529;
		 int java.sql.ParameterMetaData.isNullable(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.ParameterMetaData_._isNullable24529, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.ParameterMetaData_.staticClass, global::java.sql.ParameterMetaData_._isNullable24529, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSigned24530;
		 bool java.sql.ParameterMetaData.isSigned(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.ParameterMetaData_._isSigned24530, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.ParameterMetaData_.staticClass, global::java.sql.ParameterMetaData_._isSigned24530, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getParameterCount24531;
		 int java.sql.ParameterMetaData.getParameterCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.ParameterMetaData_._getParameterCount24531);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.ParameterMetaData_.staticClass, global::java.sql.ParameterMetaData_._getParameterCount24531);
		}
		internal static global::MonoJavaBridge.MethodId _getParameterType24532;
		 int java.sql.ParameterMetaData.getParameterType(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.ParameterMetaData_._getParameterType24532, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.ParameterMetaData_.staticClass, global::java.sql.ParameterMetaData_._getParameterType24532, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getParameterTypeName24533;
		 global::java.lang.String java.sql.ParameterMetaData.getParameterTypeName(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ParameterMetaData_._getParameterTypeName24533, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.ParameterMetaData_.staticClass, global::java.sql.ParameterMetaData_._getParameterTypeName24533, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getParameterClassName24534;
		 global::java.lang.String java.sql.ParameterMetaData.getParameterClassName(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ParameterMetaData_._getParameterClassName24534, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.ParameterMetaData_.staticClass, global::java.sql.ParameterMetaData_._getParameterClassName24534, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getParameterMode24535;
		 int java.sql.ParameterMetaData.getParameterMode(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.ParameterMetaData_._getParameterMode24535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.ParameterMetaData_.staticClass, global::java.sql.ParameterMetaData_._getParameterMode24535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.ParameterMetaData_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/ParameterMetaData"));
			global::java.sql.ParameterMetaData_._getScale24527 = @__env.GetMethodIDNoThrow(global::java.sql.ParameterMetaData_.staticClass, "getScale", "(I)I");
			global::java.sql.ParameterMetaData_._getPrecision24528 = @__env.GetMethodIDNoThrow(global::java.sql.ParameterMetaData_.staticClass, "getPrecision", "(I)I");
			global::java.sql.ParameterMetaData_._isNullable24529 = @__env.GetMethodIDNoThrow(global::java.sql.ParameterMetaData_.staticClass, "isNullable", "(I)I");
			global::java.sql.ParameterMetaData_._isSigned24530 = @__env.GetMethodIDNoThrow(global::java.sql.ParameterMetaData_.staticClass, "isSigned", "(I)Z");
			global::java.sql.ParameterMetaData_._getParameterCount24531 = @__env.GetMethodIDNoThrow(global::java.sql.ParameterMetaData_.staticClass, "getParameterCount", "()I");
			global::java.sql.ParameterMetaData_._getParameterType24532 = @__env.GetMethodIDNoThrow(global::java.sql.ParameterMetaData_.staticClass, "getParameterType", "(I)I");
			global::java.sql.ParameterMetaData_._getParameterTypeName24533 = @__env.GetMethodIDNoThrow(global::java.sql.ParameterMetaData_.staticClass, "getParameterTypeName", "(I)Ljava/lang/String;");
			global::java.sql.ParameterMetaData_._getParameterClassName24534 = @__env.GetMethodIDNoThrow(global::java.sql.ParameterMetaData_.staticClass, "getParameterClassName", "(I)Ljava/lang/String;");
			global::java.sql.ParameterMetaData_._getParameterMode24535 = @__env.GetMethodIDNoThrow(global::java.sql.ParameterMetaData_.staticClass, "getParameterMode", "(I)I");
		}
	}
}
