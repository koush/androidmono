namespace java.sql
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DriverPropertyInfo : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DriverPropertyInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public DriverPropertyInfo(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.DriverPropertyInfo._m0.native == global::System.IntPtr.Zero)
				global::java.sql.DriverPropertyInfo._m0 = @__env.GetMethodIDNoThrow(global::java.sql.DriverPropertyInfo.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.DriverPropertyInfo.staticClass, global::java.sql.DriverPropertyInfo._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _name6610;
		public global::java.lang.String name
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _name6610)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _description6611;
		public global::java.lang.String description
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _description6611)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _required6612;
		public bool required
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetBooleanField(this.JvmHandle, _required6612);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _value6613;
		public global::java.lang.String value
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _value6613)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _choices6614;
		public global::java.lang.String[] choices
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _choices6614)) as java.lang.String[];
			}
			set
			{
			}
		}
		static DriverPropertyInfo()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.DriverPropertyInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/DriverPropertyInfo"));
			global::java.sql.DriverPropertyInfo._name6610 = @__env.GetFieldIDNoThrow(global::java.sql.DriverPropertyInfo.staticClass, "name", "Ljava/lang/String;");
			global::java.sql.DriverPropertyInfo._description6611 = @__env.GetFieldIDNoThrow(global::java.sql.DriverPropertyInfo.staticClass, "description", "Ljava/lang/String;");
			global::java.sql.DriverPropertyInfo._required6612 = @__env.GetFieldIDNoThrow(global::java.sql.DriverPropertyInfo.staticClass, "required", "Z");
			global::java.sql.DriverPropertyInfo._value6613 = @__env.GetFieldIDNoThrow(global::java.sql.DriverPropertyInfo.staticClass, "value", "Ljava/lang/String;");
			global::java.sql.DriverPropertyInfo._choices6614 = @__env.GetFieldIDNoThrow(global::java.sql.DriverPropertyInfo.staticClass, "choices", "[Ljava/lang/String;");
		}
	}
}
