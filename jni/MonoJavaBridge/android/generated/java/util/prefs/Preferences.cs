namespace java.util.prefs
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.prefs.Preferences_))]
	public abstract partial class Preferences : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Preferences()
		{
			InitJNI();
		}
		protected Preferences(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _name28068;
		public abstract global::java.lang.String name();
		internal static global::MonoJavaBridge.MethodId _parent28069;
		public abstract global::java.util.prefs.Preferences parent();
		internal static global::MonoJavaBridge.MethodId _get28070;
		public abstract global::java.lang.String get(java.lang.String arg0, java.lang.String arg1);
		internal static global::MonoJavaBridge.MethodId _put28071;
		public abstract void put(java.lang.String arg0, java.lang.String arg1);
		internal static global::MonoJavaBridge.MethodId _toString28072;
		public abstract global::java.lang.String toString();
		internal static global::MonoJavaBridge.MethodId _getBoolean28073;
		public abstract bool getBoolean(java.lang.String arg0, bool arg1);
		internal static global::MonoJavaBridge.MethodId _putBoolean28074;
		public abstract void putBoolean(java.lang.String arg0, bool arg1);
		internal static global::MonoJavaBridge.MethodId _getInt28075;
		public abstract int getInt(java.lang.String arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _putInt28076;
		public abstract void putInt(java.lang.String arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _getLong28077;
		public abstract long getLong(java.lang.String arg0, long arg1);
		internal static global::MonoJavaBridge.MethodId _putLong28078;
		public abstract void putLong(java.lang.String arg0, long arg1);
		internal static global::MonoJavaBridge.MethodId _getFloat28079;
		public abstract float getFloat(java.lang.String arg0, float arg1);
		internal static global::MonoJavaBridge.MethodId _putFloat28080;
		public abstract void putFloat(java.lang.String arg0, float arg1);
		internal static global::MonoJavaBridge.MethodId _getDouble28081;
		public abstract double getDouble(java.lang.String arg0, double arg1);
		internal static global::MonoJavaBridge.MethodId _putDouble28082;
		public abstract void putDouble(java.lang.String arg0, double arg1);
		internal static global::MonoJavaBridge.MethodId _clear28083;
		public abstract void clear();
		internal static global::MonoJavaBridge.MethodId _remove28084;
		public abstract void remove(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _keys28085;
		public abstract global::java.lang.String[] keys();
		internal static global::MonoJavaBridge.MethodId _flush28086;
		public abstract void flush();
		internal static global::MonoJavaBridge.MethodId _sync28087;
		public abstract void sync();
		internal static global::MonoJavaBridge.MethodId _putByteArray28088;
		public abstract void putByteArray(java.lang.String arg0, byte[] arg1);
		internal static global::MonoJavaBridge.MethodId _getByteArray28089;
		public abstract byte[] getByteArray(java.lang.String arg0, byte[] arg1);
		internal static global::MonoJavaBridge.MethodId _node28090;
		public abstract global::java.util.prefs.Preferences node(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _absolutePath28091;
		public abstract global::java.lang.String absolutePath();
		internal static global::MonoJavaBridge.MethodId _childrenNames28092;
		public abstract global::java.lang.String[] childrenNames();
		internal static global::MonoJavaBridge.MethodId _nodeExists28093;
		public abstract bool nodeExists(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _removeNode28094;
		public abstract void removeNode();
		internal static global::MonoJavaBridge.MethodId _isUserNode28095;
		public abstract bool isUserNode();
		internal static global::MonoJavaBridge.MethodId _addPreferenceChangeListener28096;
		public abstract void addPreferenceChangeListener(java.util.prefs.PreferenceChangeListener arg0);
		internal static global::MonoJavaBridge.MethodId _removePreferenceChangeListener28097;
		public abstract void removePreferenceChangeListener(java.util.prefs.PreferenceChangeListener arg0);
		internal static global::MonoJavaBridge.MethodId _addNodeChangeListener28098;
		public abstract void addNodeChangeListener(java.util.prefs.NodeChangeListener arg0);
		internal static global::MonoJavaBridge.MethodId _removeNodeChangeListener28099;
		public abstract void removeNodeChangeListener(java.util.prefs.NodeChangeListener arg0);
		internal static global::MonoJavaBridge.MethodId _exportNode28100;
		public abstract void exportNode(java.io.OutputStream arg0);
		internal static global::MonoJavaBridge.MethodId _exportSubtree28101;
		public abstract void exportSubtree(java.io.OutputStream arg0);
		internal static global::MonoJavaBridge.MethodId _userNodeForPackage28102;
		public static global::java.util.prefs.Preferences userNodeForPackage(java.lang.Class arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.prefs.Preferences.staticClass, global::java.util.prefs.Preferences._userNodeForPackage28102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.prefs.Preferences;
		}
		internal static global::MonoJavaBridge.MethodId _systemNodeForPackage28103;
		public static global::java.util.prefs.Preferences systemNodeForPackage(java.lang.Class arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.prefs.Preferences.staticClass, global::java.util.prefs.Preferences._systemNodeForPackage28103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.prefs.Preferences;
		}
		internal static global::MonoJavaBridge.MethodId _userRoot28104;
		public static global::java.util.prefs.Preferences userRoot() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.prefs.Preferences.staticClass, global::java.util.prefs.Preferences._userRoot28104)) as java.util.prefs.Preferences;
		}
		internal static global::MonoJavaBridge.MethodId _systemRoot28105;
		public static global::java.util.prefs.Preferences systemRoot() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.prefs.Preferences.staticClass, global::java.util.prefs.Preferences._systemRoot28105)) as java.util.prefs.Preferences;
		}
		internal static global::MonoJavaBridge.MethodId _importPreferences28106;
		public static void importPreferences(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.prefs.Preferences.staticClass, global::java.util.prefs.Preferences._importPreferences28106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Preferences28107;
		protected Preferences()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.prefs.Preferences.staticClass, global::java.util.prefs.Preferences._Preferences28107);
			Init(@__env, handle);
		}
		public static int MAX_KEY_LENGTH
		{
			get
			{
				return 80;
			}
		}
		public static int MAX_VALUE_LENGTH
		{
			get
			{
				return 8192;
			}
		}
		public static int MAX_NAME_LENGTH
		{
			get
			{
				return 80;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.prefs.Preferences.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/prefs/Preferences"));
			global::java.util.prefs.Preferences._name28068 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "name", "()Ljava/lang/String;");
			global::java.util.prefs.Preferences._parent28069 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "parent", "()Ljava/util/prefs/Preferences;");
			global::java.util.prefs.Preferences._get28070 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "get", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::java.util.prefs.Preferences._put28071 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "put", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.util.prefs.Preferences._toString28072 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.prefs.Preferences._getBoolean28073 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "getBoolean", "(Ljava/lang/String;Z)Z");
			global::java.util.prefs.Preferences._putBoolean28074 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "putBoolean", "(Ljava/lang/String;Z)V");
			global::java.util.prefs.Preferences._getInt28075 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "getInt", "(Ljava/lang/String;I)I");
			global::java.util.prefs.Preferences._putInt28076 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "putInt", "(Ljava/lang/String;I)V");
			global::java.util.prefs.Preferences._getLong28077 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "getLong", "(Ljava/lang/String;J)J");
			global::java.util.prefs.Preferences._putLong28078 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "putLong", "(Ljava/lang/String;J)V");
			global::java.util.prefs.Preferences._getFloat28079 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "getFloat", "(Ljava/lang/String;F)F");
			global::java.util.prefs.Preferences._putFloat28080 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "putFloat", "(Ljava/lang/String;F)V");
			global::java.util.prefs.Preferences._getDouble28081 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "getDouble", "(Ljava/lang/String;D)D");
			global::java.util.prefs.Preferences._putDouble28082 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "putDouble", "(Ljava/lang/String;D)V");
			global::java.util.prefs.Preferences._clear28083 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "clear", "()V");
			global::java.util.prefs.Preferences._remove28084 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "remove", "(Ljava/lang/String;)V");
			global::java.util.prefs.Preferences._keys28085 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "keys", "()[Ljava/lang/String;");
			global::java.util.prefs.Preferences._flush28086 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "flush", "()V");
			global::java.util.prefs.Preferences._sync28087 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "sync", "()V");
			global::java.util.prefs.Preferences._putByteArray28088 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "putByteArray", "(Ljava/lang/String;[B)V");
			global::java.util.prefs.Preferences._getByteArray28089 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "getByteArray", "(Ljava/lang/String;[B)[B");
			global::java.util.prefs.Preferences._node28090 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "node", "(Ljava/lang/String;)Ljava/util/prefs/Preferences;");
			global::java.util.prefs.Preferences._absolutePath28091 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "absolutePath", "()Ljava/lang/String;");
			global::java.util.prefs.Preferences._childrenNames28092 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "childrenNames", "()[Ljava/lang/String;");
			global::java.util.prefs.Preferences._nodeExists28093 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "nodeExists", "(Ljava/lang/String;)Z");
			global::java.util.prefs.Preferences._removeNode28094 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "removeNode", "()V");
			global::java.util.prefs.Preferences._isUserNode28095 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "isUserNode", "()Z");
			global::java.util.prefs.Preferences._addPreferenceChangeListener28096 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "addPreferenceChangeListener", "(Ljava/util/prefs/PreferenceChangeListener;)V");
			global::java.util.prefs.Preferences._removePreferenceChangeListener28097 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "removePreferenceChangeListener", "(Ljava/util/prefs/PreferenceChangeListener;)V");
			global::java.util.prefs.Preferences._addNodeChangeListener28098 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "addNodeChangeListener", "(Ljava/util/prefs/NodeChangeListener;)V");
			global::java.util.prefs.Preferences._removeNodeChangeListener28099 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "removeNodeChangeListener", "(Ljava/util/prefs/NodeChangeListener;)V");
			global::java.util.prefs.Preferences._exportNode28100 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "exportNode", "(Ljava/io/OutputStream;)V");
			global::java.util.prefs.Preferences._exportSubtree28101 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "exportSubtree", "(Ljava/io/OutputStream;)V");
			global::java.util.prefs.Preferences._userNodeForPackage28102 = @__env.GetStaticMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "userNodeForPackage", "(Ljava/lang/Class;)Ljava/util/prefs/Preferences;");
			global::java.util.prefs.Preferences._systemNodeForPackage28103 = @__env.GetStaticMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "systemNodeForPackage", "(Ljava/lang/Class;)Ljava/util/prefs/Preferences;");
			global::java.util.prefs.Preferences._userRoot28104 = @__env.GetStaticMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "userRoot", "()Ljava/util/prefs/Preferences;");
			global::java.util.prefs.Preferences._systemRoot28105 = @__env.GetStaticMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "systemRoot", "()Ljava/util/prefs/Preferences;");
			global::java.util.prefs.Preferences._importPreferences28106 = @__env.GetStaticMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "importPreferences", "(Ljava/io/InputStream;)V");
			global::java.util.prefs.Preferences._Preferences28107 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.prefs.Preferences))]
	public sealed partial class Preferences_ : java.util.prefs.Preferences
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Preferences_()
		{
			InitJNI();
		}
		internal Preferences_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _name28111;
		public override global::java.lang.String name() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.Preferences_._name28111)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._name28111)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _parent28112;
		public override global::java.util.prefs.Preferences parent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.Preferences_._parent28112)) as java.util.prefs.Preferences;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._parent28112)) as java.util.prefs.Preferences;
		}
		internal static global::MonoJavaBridge.MethodId _get28113;
		public override global::java.lang.String get(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.Preferences_._get28113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._get28113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _put28114;
		public override void put(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_._put28114, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._put28114, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _toString28115;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.Preferences_._toString28115)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._toString28115)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getBoolean28116;
		public override bool getBoolean(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.prefs.Preferences_._getBoolean28116, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._getBoolean28116, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putBoolean28117;
		public override void putBoolean(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_._putBoolean28117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._putBoolean28117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getInt28118;
		public override int getInt(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.prefs.Preferences_._getInt28118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._getInt28118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putInt28119;
		public override void putInt(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_._putInt28119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._putInt28119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getLong28120;
		public override long getLong(java.lang.String arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.prefs.Preferences_._getLong28120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._getLong28120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putLong28121;
		public override void putLong(java.lang.String arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_._putLong28121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._putLong28121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFloat28122;
		public override float getFloat(java.lang.String arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.util.prefs.Preferences_._getFloat28122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._getFloat28122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putFloat28123;
		public override void putFloat(java.lang.String arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_._putFloat28123, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._putFloat28123, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getDouble28124;
		public override double getDouble(java.lang.String arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.util.prefs.Preferences_._getDouble28124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._getDouble28124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putDouble28125;
		public override void putDouble(java.lang.String arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_._putDouble28125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._putDouble28125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _clear28126;
		public override void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_._clear28126);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._clear28126);
		}
		internal static global::MonoJavaBridge.MethodId _remove28127;
		public override void remove(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_._remove28127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._remove28127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _keys28128;
		public override global::java.lang.String[] keys() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.Preferences_._keys28128)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._keys28128)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _flush28129;
		public override void flush() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_._flush28129);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._flush28129);
		}
		internal static global::MonoJavaBridge.MethodId _sync28130;
		public override void sync() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_._sync28130);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._sync28130);
		}
		internal static global::MonoJavaBridge.MethodId _putByteArray28131;
		public override void putByteArray(java.lang.String arg0, byte[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_._putByteArray28131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._putByteArray28131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getByteArray28132;
		public override byte[] getByteArray(java.lang.String arg0, byte[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.Preferences_._getByteArray28132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._getByteArray28132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _node28133;
		public override global::java.util.prefs.Preferences node(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.Preferences_._node28133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.prefs.Preferences;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._node28133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.prefs.Preferences;
		}
		internal static global::MonoJavaBridge.MethodId _absolutePath28134;
		public override global::java.lang.String absolutePath() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.Preferences_._absolutePath28134)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._absolutePath28134)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _childrenNames28135;
		public override global::java.lang.String[] childrenNames() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.Preferences_._childrenNames28135)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._childrenNames28135)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _nodeExists28136;
		public override bool nodeExists(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.prefs.Preferences_._nodeExists28136, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._nodeExists28136, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeNode28137;
		public override void removeNode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_._removeNode28137);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._removeNode28137);
		}
		internal static global::MonoJavaBridge.MethodId _isUserNode28138;
		public override bool isUserNode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.prefs.Preferences_._isUserNode28138);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._isUserNode28138);
		}
		internal static global::MonoJavaBridge.MethodId _addPreferenceChangeListener28139;
		public override void addPreferenceChangeListener(java.util.prefs.PreferenceChangeListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_._addPreferenceChangeListener28139, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._addPreferenceChangeListener28139, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removePreferenceChangeListener28140;
		public override void removePreferenceChangeListener(java.util.prefs.PreferenceChangeListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_._removePreferenceChangeListener28140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._removePreferenceChangeListener28140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addNodeChangeListener28141;
		public override void addNodeChangeListener(java.util.prefs.NodeChangeListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_._addNodeChangeListener28141, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._addNodeChangeListener28141, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeNodeChangeListener28142;
		public override void removeNodeChangeListener(java.util.prefs.NodeChangeListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_._removeNodeChangeListener28142, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._removeNodeChangeListener28142, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _exportNode28143;
		public override void exportNode(java.io.OutputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_._exportNode28143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._exportNode28143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _exportSubtree28144;
		public override void exportSubtree(java.io.OutputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_._exportSubtree28144, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._exportSubtree28144, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.prefs.Preferences_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/prefs/Preferences"));
			global::java.util.prefs.Preferences_._name28111 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "name", "()Ljava/lang/String;");
			global::java.util.prefs.Preferences_._parent28112 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "parent", "()Ljava/util/prefs/Preferences;");
			global::java.util.prefs.Preferences_._get28113 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "get", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::java.util.prefs.Preferences_._put28114 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "put", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.util.prefs.Preferences_._toString28115 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.prefs.Preferences_._getBoolean28116 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "getBoolean", "(Ljava/lang/String;Z)Z");
			global::java.util.prefs.Preferences_._putBoolean28117 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "putBoolean", "(Ljava/lang/String;Z)V");
			global::java.util.prefs.Preferences_._getInt28118 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "getInt", "(Ljava/lang/String;I)I");
			global::java.util.prefs.Preferences_._putInt28119 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "putInt", "(Ljava/lang/String;I)V");
			global::java.util.prefs.Preferences_._getLong28120 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "getLong", "(Ljava/lang/String;J)J");
			global::java.util.prefs.Preferences_._putLong28121 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "putLong", "(Ljava/lang/String;J)V");
			global::java.util.prefs.Preferences_._getFloat28122 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "getFloat", "(Ljava/lang/String;F)F");
			global::java.util.prefs.Preferences_._putFloat28123 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "putFloat", "(Ljava/lang/String;F)V");
			global::java.util.prefs.Preferences_._getDouble28124 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "getDouble", "(Ljava/lang/String;D)D");
			global::java.util.prefs.Preferences_._putDouble28125 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "putDouble", "(Ljava/lang/String;D)V");
			global::java.util.prefs.Preferences_._clear28126 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "clear", "()V");
			global::java.util.prefs.Preferences_._remove28127 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "remove", "(Ljava/lang/String;)V");
			global::java.util.prefs.Preferences_._keys28128 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "keys", "()[Ljava/lang/String;");
			global::java.util.prefs.Preferences_._flush28129 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "flush", "()V");
			global::java.util.prefs.Preferences_._sync28130 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "sync", "()V");
			global::java.util.prefs.Preferences_._putByteArray28131 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "putByteArray", "(Ljava/lang/String;[B)V");
			global::java.util.prefs.Preferences_._getByteArray28132 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "getByteArray", "(Ljava/lang/String;[B)[B");
			global::java.util.prefs.Preferences_._node28133 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "node", "(Ljava/lang/String;)Ljava/util/prefs/Preferences;");
			global::java.util.prefs.Preferences_._absolutePath28134 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "absolutePath", "()Ljava/lang/String;");
			global::java.util.prefs.Preferences_._childrenNames28135 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "childrenNames", "()[Ljava/lang/String;");
			global::java.util.prefs.Preferences_._nodeExists28136 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "nodeExists", "(Ljava/lang/String;)Z");
			global::java.util.prefs.Preferences_._removeNode28137 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "removeNode", "()V");
			global::java.util.prefs.Preferences_._isUserNode28138 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "isUserNode", "()Z");
			global::java.util.prefs.Preferences_._addPreferenceChangeListener28139 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "addPreferenceChangeListener", "(Ljava/util/prefs/PreferenceChangeListener;)V");
			global::java.util.prefs.Preferences_._removePreferenceChangeListener28140 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "removePreferenceChangeListener", "(Ljava/util/prefs/PreferenceChangeListener;)V");
			global::java.util.prefs.Preferences_._addNodeChangeListener28141 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "addNodeChangeListener", "(Ljava/util/prefs/NodeChangeListener;)V");
			global::java.util.prefs.Preferences_._removeNodeChangeListener28142 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "removeNodeChangeListener", "(Ljava/util/prefs/NodeChangeListener;)V");
			global::java.util.prefs.Preferences_._exportNode28143 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "exportNode", "(Ljava/io/OutputStream;)V");
			global::java.util.prefs.Preferences_._exportSubtree28144 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "exportSubtree", "(Ljava/io/OutputStream;)V");
		}
	}
}
