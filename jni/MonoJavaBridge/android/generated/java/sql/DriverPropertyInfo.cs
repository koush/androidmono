namespace java.sql
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DriverPropertyInfo : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DriverPropertyInfo()
		{
			InitJNI();
		}
		protected DriverPropertyInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _DriverPropertyInfo24639;
		public DriverPropertyInfo(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.DriverPropertyInfo.staticClass, global::java.sql.DriverPropertyInfo._DriverPropertyInfo24639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _name24640;
		public global::java.lang.String name
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _name24640)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _description24641;
		public global::java.lang.String description
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _description24641)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _required24642;
		public bool required
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetBooleanField(this.JvmHandle, _required24642);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _value24643;
		public global::java.lang.String value
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _value24643)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _choices24644;
		public global::java.lang.String[] choices
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _choices24644)) as java.lang.String[];
			}
			set
			{
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.DriverPropertyInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/DriverPropertyInfo"));
			global::java.sql.DriverPropertyInfo._DriverPropertyInfo24639 = @__env.GetMethodIDNoThrow(global::java.sql.DriverPropertyInfo.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.sql.DriverPropertyInfo._name24640 = @__env.GetFieldIDNoThrow(global::java.sql.DriverPropertyInfo.staticClass, "name", "Ljava/lang/String;");
			global::java.sql.DriverPropertyInfo._description24641 = @__env.GetFieldIDNoThrow(global::java.sql.DriverPropertyInfo.staticClass, "description", "Ljava/lang/String;");
			global::java.sql.DriverPropertyInfo._required24642 = @__env.GetFieldIDNoThrow(global::java.sql.DriverPropertyInfo.staticClass, "required", "Z");
			global::java.sql.DriverPropertyInfo._value24643 = @__env.GetFieldIDNoThrow(global::java.sql.DriverPropertyInfo.staticClass, "value", "Ljava/lang/String;");
			global::java.sql.DriverPropertyInfo._choices24644 = @__env.GetFieldIDNoThrow(global::java.sql.DriverPropertyInfo.staticClass, "choices", "[Ljava/lang/String;");
		}
	}
}
