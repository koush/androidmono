namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Properties : java.util.Hashtable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Properties(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setProperty26556;
		public virtual global::java.lang.Object setProperty(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.Properties.staticClass, global::java.util.Properties._setProperty26556, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getProperty26557;
		public virtual global::java.lang.String getProperty(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.Properties.staticClass, global::java.util.Properties._getProperty26557, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getProperty26558;
		public virtual global::java.lang.String getProperty(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.Properties.staticClass, global::java.util.Properties._getProperty26558, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _load26559;
		public virtual void load(java.io.Reader arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Properties.staticClass, global::java.util.Properties._load26559, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _load26560;
		public virtual void load(java.io.InputStream arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Properties.staticClass, global::java.util.Properties._load26560, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _list26561;
		public virtual void list(java.io.PrintStream arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Properties.staticClass, global::java.util.Properties._list26561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _list26562;
		public virtual void list(java.io.PrintWriter arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Properties.staticClass, global::java.util.Properties._list26562, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _save26563;
		public virtual void save(java.io.OutputStream arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Properties.staticClass, global::java.util.Properties._save26563, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _store26564;
		public virtual void store(java.io.Writer arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Properties.staticClass, global::java.util.Properties._store26564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _store26565;
		public virtual void store(java.io.OutputStream arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Properties.staticClass, global::java.util.Properties._store26565, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _loadFromXML26566;
		public virtual void loadFromXML(java.io.InputStream arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Properties.staticClass, global::java.util.Properties._loadFromXML26566, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _storeToXML26567;
		public virtual void storeToXML(java.io.OutputStream arg0, java.lang.String arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Properties.staticClass, global::java.util.Properties._storeToXML26567, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _storeToXML26568;
		public virtual void storeToXML(java.io.OutputStream arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Properties.staticClass, global::java.util.Properties._storeToXML26568, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _propertyNames26569;
		public virtual global::java.util.Enumeration propertyNames()
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.Properties.staticClass, global::java.util.Properties._propertyNames26569)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _stringPropertyNames26570;
		public virtual global::java.util.Set stringPropertyNames()
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.Properties.staticClass, global::java.util.Properties._stringPropertyNames26570)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _Properties26571;
		public Properties() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Properties.staticClass, global::java.util.Properties._Properties26571);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Properties26572;
		public Properties(java.util.Properties arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Properties.staticClass, global::java.util.Properties._Properties26572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static Properties()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Properties.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Properties"));
			global::java.util.Properties._setProperty26556 = @__env.GetMethodIDNoThrow(global::java.util.Properties.staticClass, "setProperty", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Object;");
			global::java.util.Properties._getProperty26557 = @__env.GetMethodIDNoThrow(global::java.util.Properties.staticClass, "getProperty", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::java.util.Properties._getProperty26558 = @__env.GetMethodIDNoThrow(global::java.util.Properties.staticClass, "getProperty", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.util.Properties._load26559 = @__env.GetMethodIDNoThrow(global::java.util.Properties.staticClass, "load", "(Ljava/io/Reader;)V");
			global::java.util.Properties._load26560 = @__env.GetMethodIDNoThrow(global::java.util.Properties.staticClass, "load", "(Ljava/io/InputStream;)V");
			global::java.util.Properties._list26561 = @__env.GetMethodIDNoThrow(global::java.util.Properties.staticClass, "list", "(Ljava/io/PrintStream;)V");
			global::java.util.Properties._list26562 = @__env.GetMethodIDNoThrow(global::java.util.Properties.staticClass, "list", "(Ljava/io/PrintWriter;)V");
			global::java.util.Properties._save26563 = @__env.GetMethodIDNoThrow(global::java.util.Properties.staticClass, "save", "(Ljava/io/OutputStream;Ljava/lang/String;)V");
			global::java.util.Properties._store26564 = @__env.GetMethodIDNoThrow(global::java.util.Properties.staticClass, "store", "(Ljava/io/Writer;Ljava/lang/String;)V");
			global::java.util.Properties._store26565 = @__env.GetMethodIDNoThrow(global::java.util.Properties.staticClass, "store", "(Ljava/io/OutputStream;Ljava/lang/String;)V");
			global::java.util.Properties._loadFromXML26566 = @__env.GetMethodIDNoThrow(global::java.util.Properties.staticClass, "loadFromXML", "(Ljava/io/InputStream;)V");
			global::java.util.Properties._storeToXML26567 = @__env.GetMethodIDNoThrow(global::java.util.Properties.staticClass, "storeToXML", "(Ljava/io/OutputStream;Ljava/lang/String;Ljava/lang/String;)V");
			global::java.util.Properties._storeToXML26568 = @__env.GetMethodIDNoThrow(global::java.util.Properties.staticClass, "storeToXML", "(Ljava/io/OutputStream;Ljava/lang/String;)V");
			global::java.util.Properties._propertyNames26569 = @__env.GetMethodIDNoThrow(global::java.util.Properties.staticClass, "propertyNames", "()Ljava/util/Enumeration;");
			global::java.util.Properties._stringPropertyNames26570 = @__env.GetMethodIDNoThrow(global::java.util.Properties.staticClass, "stringPropertyNames", "()Ljava/util/Set;");
			global::java.util.Properties._Properties26571 = @__env.GetMethodIDNoThrow(global::java.util.Properties.staticClass, "<init>", "()V");
			global::java.util.Properties._Properties26572 = @__env.GetMethodIDNoThrow(global::java.util.Properties.staticClass, "<init>", "(Ljava/util/Properties;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
