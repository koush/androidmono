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
		internal static global::MonoJavaBridge.MethodId _DriverPropertyInfo18846;
		public DriverPropertyInfo(java.lang.String arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.DriverPropertyInfo.staticClass, global::java.sql.DriverPropertyInfo._DriverPropertyInfo18846, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _name18847;
		public global::java.lang.String name
		{
			get
			{
				return default(global::java.lang.String);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _description18848;
		public global::java.lang.String description
		{
			get
			{
				return default(global::java.lang.String);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _required18849;
		public bool required
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _value18850;
		public global::java.lang.String value
		{
			get
			{
				return default(global::java.lang.String);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _choices18851;
		public global::java.lang.String[] choices
		{
			get
			{
				return default(global::java.lang.String[]);
			}
			set
			{
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.DriverPropertyInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/DriverPropertyInfo"));
			global::java.sql.DriverPropertyInfo._DriverPropertyInfo18846 = @__env.GetMethodIDNoThrow(global::java.sql.DriverPropertyInfo.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
		}
	}
}
