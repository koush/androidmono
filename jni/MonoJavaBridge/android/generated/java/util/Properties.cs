namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Properties : java.util.Hashtable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Properties()
		{
			InitJNI();
		}
		protected Properties(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setProperty20612;
		public virtual global::java.lang.Object setProperty(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Properties._setProperty20612, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Properties.staticClass, global::java.util.Properties._setProperty20612, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getProperty20613;
		public virtual global::java.lang.String getProperty(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Properties._getProperty20613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Properties.staticClass, global::java.util.Properties._getProperty20613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getProperty20614;
		public virtual global::java.lang.String getProperty(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Properties._getProperty20614, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Properties.staticClass, global::java.util.Properties._getProperty20614, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _load20615;
		public virtual void load(java.io.Reader arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Properties._load20615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Properties.staticClass, global::java.util.Properties._load20615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _load20616;
		public virtual void load(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Properties._load20616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Properties.staticClass, global::java.util.Properties._load20616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _list20617;
		public virtual void list(java.io.PrintStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Properties._list20617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Properties.staticClass, global::java.util.Properties._list20617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _list20618;
		public virtual void list(java.io.PrintWriter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Properties._list20618, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Properties.staticClass, global::java.util.Properties._list20618, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _save20619;
		public virtual void save(java.io.OutputStream arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Properties._save20619, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Properties.staticClass, global::java.util.Properties._save20619, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _store20620;
		public virtual void store(java.io.Writer arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Properties._store20620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Properties.staticClass, global::java.util.Properties._store20620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _store20621;
		public virtual void store(java.io.OutputStream arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Properties._store20621, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Properties.staticClass, global::java.util.Properties._store20621, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _loadFromXML20622;
		public virtual void loadFromXML(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Properties._loadFromXML20622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Properties.staticClass, global::java.util.Properties._loadFromXML20622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _storeToXML20623;
		public virtual void storeToXML(java.io.OutputStream arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Properties._storeToXML20623, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Properties.staticClass, global::java.util.Properties._storeToXML20623, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _storeToXML20624;
		public virtual void storeToXML(java.io.OutputStream arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Properties._storeToXML20624, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Properties.staticClass, global::java.util.Properties._storeToXML20624, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _propertyNames20625;
		public virtual global::java.util.Enumeration propertyNames() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Properties._propertyNames20625)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Properties.staticClass, global::java.util.Properties._propertyNames20625)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _stringPropertyNames20626;
		public virtual global::java.util.Set stringPropertyNames() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Properties._stringPropertyNames20626)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Properties.staticClass, global::java.util.Properties._stringPropertyNames20626)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _Properties20627;
		public Properties()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Properties.staticClass, global::java.util.Properties._Properties20627);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Properties20628;
		public Properties(java.util.Properties arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Properties.staticClass, global::java.util.Properties._Properties20628, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Properties.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Properties"));
			global::java.util.Properties._setProperty20612 = @__env.GetMethodIDNoThrow(global::java.util.Properties.staticClass, "setProperty", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Object;");
			global::java.util.Properties._getProperty20613 = @__env.GetMethodIDNoThrow(global::java.util.Properties.staticClass, "getProperty", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::java.util.Properties._getProperty20614 = @__env.GetMethodIDNoThrow(global::java.util.Properties.staticClass, "getProperty", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.util.Properties._load20615 = @__env.GetMethodIDNoThrow(global::java.util.Properties.staticClass, "load", "(Ljava/io/Reader;)V");
			global::java.util.Properties._load20616 = @__env.GetMethodIDNoThrow(global::java.util.Properties.staticClass, "load", "(Ljava/io/InputStream;)V");
			global::java.util.Properties._list20617 = @__env.GetMethodIDNoThrow(global::java.util.Properties.staticClass, "list", "(Ljava/io/PrintStream;)V");
			global::java.util.Properties._list20618 = @__env.GetMethodIDNoThrow(global::java.util.Properties.staticClass, "list", "(Ljava/io/PrintWriter;)V");
			global::java.util.Properties._save20619 = @__env.GetMethodIDNoThrow(global::java.util.Properties.staticClass, "save", "(Ljava/io/OutputStream;Ljava/lang/String;)V");
			global::java.util.Properties._store20620 = @__env.GetMethodIDNoThrow(global::java.util.Properties.staticClass, "store", "(Ljava/io/Writer;Ljava/lang/String;)V");
			global::java.util.Properties._store20621 = @__env.GetMethodIDNoThrow(global::java.util.Properties.staticClass, "store", "(Ljava/io/OutputStream;Ljava/lang/String;)V");
			global::java.util.Properties._loadFromXML20622 = @__env.GetMethodIDNoThrow(global::java.util.Properties.staticClass, "loadFromXML", "(Ljava/io/InputStream;)V");
			global::java.util.Properties._storeToXML20623 = @__env.GetMethodIDNoThrow(global::java.util.Properties.staticClass, "storeToXML", "(Ljava/io/OutputStream;Ljava/lang/String;Ljava/lang/String;)V");
			global::java.util.Properties._storeToXML20624 = @__env.GetMethodIDNoThrow(global::java.util.Properties.staticClass, "storeToXML", "(Ljava/io/OutputStream;Ljava/lang/String;)V");
			global::java.util.Properties._propertyNames20625 = @__env.GetMethodIDNoThrow(global::java.util.Properties.staticClass, "propertyNames", "()Ljava/util/Enumeration;");
			global::java.util.Properties._stringPropertyNames20626 = @__env.GetMethodIDNoThrow(global::java.util.Properties.staticClass, "stringPropertyNames", "()Ljava/util/Set;");
			global::java.util.Properties._Properties20627 = @__env.GetMethodIDNoThrow(global::java.util.Properties.staticClass, "<init>", "()V");
			global::java.util.Properties._Properties20628 = @__env.GetMethodIDNoThrow(global::java.util.Properties.staticClass, "<init>", "(Ljava/util/Properties;)V");
		}
	}
}
