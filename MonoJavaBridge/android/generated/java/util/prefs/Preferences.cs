namespace java.util.prefs
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.prefs.Preferences_))]
	public abstract partial class Preferences : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Preferences(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _name28187;
		public abstract global::java.lang.String name();
		internal static global::MonoJavaBridge.MethodId _parent28188;
		public abstract global::java.util.prefs.Preferences parent();
		internal static global::MonoJavaBridge.MethodId _get28189;
		public abstract global::java.lang.String get(java.lang.String arg0, java.lang.String arg1);
		internal static global::MonoJavaBridge.MethodId _put28190;
		public abstract void put(java.lang.String arg0, java.lang.String arg1);
		internal static global::MonoJavaBridge.MethodId _toString28191;
		public abstract global::java.lang.String toString();
		internal static global::MonoJavaBridge.MethodId _getBoolean28192;
		public abstract bool getBoolean(java.lang.String arg0, bool arg1);
		internal static global::MonoJavaBridge.MethodId _putBoolean28193;
		public abstract void putBoolean(java.lang.String arg0, bool arg1);
		internal static global::MonoJavaBridge.MethodId _getInt28194;
		public abstract int getInt(java.lang.String arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _putInt28195;
		public abstract void putInt(java.lang.String arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _getLong28196;
		public abstract long getLong(java.lang.String arg0, long arg1);
		internal static global::MonoJavaBridge.MethodId _putLong28197;
		public abstract void putLong(java.lang.String arg0, long arg1);
		internal static global::MonoJavaBridge.MethodId _getFloat28198;
		public abstract float getFloat(java.lang.String arg0, float arg1);
		internal static global::MonoJavaBridge.MethodId _putFloat28199;
		public abstract void putFloat(java.lang.String arg0, float arg1);
		internal static global::MonoJavaBridge.MethodId _getDouble28200;
		public abstract double getDouble(java.lang.String arg0, double arg1);
		internal static global::MonoJavaBridge.MethodId _putDouble28201;
		public abstract void putDouble(java.lang.String arg0, double arg1);
		internal static global::MonoJavaBridge.MethodId _clear28202;
		public abstract void clear();
		internal static global::MonoJavaBridge.MethodId _remove28203;
		public abstract void remove(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _keys28204;
		public abstract global::java.lang.String[] keys();
		internal static global::MonoJavaBridge.MethodId _flush28205;
		public abstract void flush();
		internal static global::MonoJavaBridge.MethodId _sync28206;
		public abstract void sync();
		internal static global::MonoJavaBridge.MethodId _putByteArray28207;
		public abstract void putByteArray(java.lang.String arg0, byte[] arg1);
		internal static global::MonoJavaBridge.MethodId _getByteArray28208;
		public abstract byte[] getByteArray(java.lang.String arg0, byte[] arg1);
		internal static global::MonoJavaBridge.MethodId _node28209;
		public abstract global::java.util.prefs.Preferences node(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _absolutePath28210;
		public abstract global::java.lang.String absolutePath();
		internal static global::MonoJavaBridge.MethodId _childrenNames28211;
		public abstract global::java.lang.String[] childrenNames();
		internal static global::MonoJavaBridge.MethodId _nodeExists28212;
		public abstract bool nodeExists(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _removeNode28213;
		public abstract void removeNode();
		internal static global::MonoJavaBridge.MethodId _isUserNode28214;
		public abstract bool isUserNode();
		internal static global::MonoJavaBridge.MethodId _addPreferenceChangeListener28215;
		public abstract void addPreferenceChangeListener(java.util.prefs.PreferenceChangeListener arg0);
		internal static global::MonoJavaBridge.MethodId _removePreferenceChangeListener28216;
		public abstract void removePreferenceChangeListener(java.util.prefs.PreferenceChangeListener arg0);
		internal static global::MonoJavaBridge.MethodId _addNodeChangeListener28217;
		public abstract void addNodeChangeListener(java.util.prefs.NodeChangeListener arg0);
		internal static global::MonoJavaBridge.MethodId _removeNodeChangeListener28218;
		public abstract void removeNodeChangeListener(java.util.prefs.NodeChangeListener arg0);
		internal static global::MonoJavaBridge.MethodId _exportNode28219;
		public abstract void exportNode(java.io.OutputStream arg0);
		internal static global::MonoJavaBridge.MethodId _exportSubtree28220;
		public abstract void exportSubtree(java.io.OutputStream arg0);
		internal static global::MonoJavaBridge.MethodId _userNodeForPackage28221;
		public static global::java.util.prefs.Preferences userNodeForPackage(java.lang.Class arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.prefs.Preferences._userNodeForPackage28221.native == global::System.IntPtr.Zero)
				global::java.util.prefs.Preferences._userNodeForPackage28221 = @__env.GetStaticMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "userNodeForPackage", "(Ljava/lang/Class;)Ljava/util/prefs/Preferences;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.prefs.Preferences.staticClass, global::java.util.prefs.Preferences._userNodeForPackage28221, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.prefs.Preferences;
		}
		internal static global::MonoJavaBridge.MethodId _systemNodeForPackage28222;
		public static global::java.util.prefs.Preferences systemNodeForPackage(java.lang.Class arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.prefs.Preferences._systemNodeForPackage28222.native == global::System.IntPtr.Zero)
				global::java.util.prefs.Preferences._systemNodeForPackage28222 = @__env.GetStaticMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "systemNodeForPackage", "(Ljava/lang/Class;)Ljava/util/prefs/Preferences;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.prefs.Preferences.staticClass, global::java.util.prefs.Preferences._systemNodeForPackage28222, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.prefs.Preferences;
		}
		internal static global::MonoJavaBridge.MethodId _userRoot28223;
		public static global::java.util.prefs.Preferences userRoot()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.prefs.Preferences._userRoot28223.native == global::System.IntPtr.Zero)
				global::java.util.prefs.Preferences._userRoot28223 = @__env.GetStaticMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "userRoot", "()Ljava/util/prefs/Preferences;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.prefs.Preferences.staticClass, global::java.util.prefs.Preferences._userRoot28223)) as java.util.prefs.Preferences;
		}
		internal static global::MonoJavaBridge.MethodId _systemRoot28224;
		public static global::java.util.prefs.Preferences systemRoot()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.prefs.Preferences._systemRoot28224.native == global::System.IntPtr.Zero)
				global::java.util.prefs.Preferences._systemRoot28224 = @__env.GetStaticMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "systemRoot", "()Ljava/util/prefs/Preferences;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.prefs.Preferences.staticClass, global::java.util.prefs.Preferences._systemRoot28224)) as java.util.prefs.Preferences;
		}
		internal static global::MonoJavaBridge.MethodId _importPreferences28225;
		public static void importPreferences(java.io.InputStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.prefs.Preferences._importPreferences28225.native == global::System.IntPtr.Zero)
				global::java.util.prefs.Preferences._importPreferences28225 = @__env.GetStaticMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "importPreferences", "(Ljava/io/InputStream;)V");
			@__env.CallStaticVoidMethod(java.util.prefs.Preferences.staticClass, global::java.util.prefs.Preferences._importPreferences28225, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Preferences28226;
		protected Preferences() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.prefs.Preferences._Preferences28226.native == global::System.IntPtr.Zero)
				global::java.util.prefs.Preferences._Preferences28226 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.prefs.Preferences.staticClass, global::java.util.prefs.Preferences._Preferences28226);
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
		static Preferences()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.prefs.Preferences.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/prefs/Preferences"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.prefs.Preferences))]
	internal sealed partial class Preferences_ : java.util.prefs.Preferences
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Preferences_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _name28230;
		public override global::java.lang.String name()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.prefs.Preferences_.staticClass, "name", "()Ljava/lang/String;", ref global::java.util.prefs.Preferences_._name28230) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _parent28231;
		public override global::java.util.prefs.Preferences parent()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.prefs.Preferences_.staticClass, "parent", "()Ljava/util/prefs/Preferences;", ref global::java.util.prefs.Preferences_._parent28231) as java.util.prefs.Preferences;
		}
		internal static global::MonoJavaBridge.MethodId _get28232;
		public override global::java.lang.String get(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.prefs.Preferences_.staticClass, "get", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", ref global::java.util.prefs.Preferences_._get28232, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _put28233;
		public override void put(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.prefs.Preferences_.staticClass, "put", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::java.util.prefs.Preferences_._put28233, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _toString28234;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.prefs.Preferences_.staticClass, "toString", "()Ljava/lang/String;", ref global::java.util.prefs.Preferences_._toString28234) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getBoolean28235;
		public override bool getBoolean(java.lang.String arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.prefs.Preferences_.staticClass, "getBoolean", "(Ljava/lang/String;Z)Z", ref global::java.util.prefs.Preferences_._getBoolean28235, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putBoolean28236;
		public override void putBoolean(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.prefs.Preferences_.staticClass, "putBoolean", "(Ljava/lang/String;Z)V", ref global::java.util.prefs.Preferences_._putBoolean28236, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getInt28237;
		public override int getInt(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.prefs.Preferences_.staticClass, "getInt", "(Ljava/lang/String;I)I", ref global::java.util.prefs.Preferences_._getInt28237, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putInt28238;
		public override void putInt(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.prefs.Preferences_.staticClass, "putInt", "(Ljava/lang/String;I)V", ref global::java.util.prefs.Preferences_._putInt28238, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getLong28239;
		public override long getLong(java.lang.String arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.prefs.Preferences_.staticClass, "getLong", "(Ljava/lang/String;J)J", ref global::java.util.prefs.Preferences_._getLong28239, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putLong28240;
		public override void putLong(java.lang.String arg0, long arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.prefs.Preferences_.staticClass, "putLong", "(Ljava/lang/String;J)V", ref global::java.util.prefs.Preferences_._putLong28240, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFloat28241;
		public override float getFloat(java.lang.String arg0, float arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::java.util.prefs.Preferences_.staticClass, "getFloat", "(Ljava/lang/String;F)F", ref global::java.util.prefs.Preferences_._getFloat28241, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putFloat28242;
		public override void putFloat(java.lang.String arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.prefs.Preferences_.staticClass, "putFloat", "(Ljava/lang/String;F)V", ref global::java.util.prefs.Preferences_._putFloat28242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getDouble28243;
		public override double getDouble(java.lang.String arg0, double arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::java.util.prefs.Preferences_.staticClass, "getDouble", "(Ljava/lang/String;D)D", ref global::java.util.prefs.Preferences_._getDouble28243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putDouble28244;
		public override void putDouble(java.lang.String arg0, double arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.prefs.Preferences_.staticClass, "putDouble", "(Ljava/lang/String;D)V", ref global::java.util.prefs.Preferences_._putDouble28244, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _clear28245;
		public override void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.prefs.Preferences_.staticClass, "clear", "()V", ref global::java.util.prefs.Preferences_._clear28245);
		}
		internal static global::MonoJavaBridge.MethodId _remove28246;
		public override void remove(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.prefs.Preferences_.staticClass, "remove", "(Ljava/lang/String;)V", ref global::java.util.prefs.Preferences_._remove28246, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _keys28247;
		public override global::java.lang.String[] keys()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::java.util.prefs.Preferences_.staticClass, "keys", "()[Ljava/lang/String;", ref global::java.util.prefs.Preferences_._keys28247) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _flush28248;
		public override void flush()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.prefs.Preferences_.staticClass, "flush", "()V", ref global::java.util.prefs.Preferences_._flush28248);
		}
		internal static global::MonoJavaBridge.MethodId _sync28249;
		public override void sync()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.prefs.Preferences_.staticClass, "sync", "()V", ref global::java.util.prefs.Preferences_._sync28249);
		}
		internal static global::MonoJavaBridge.MethodId _putByteArray28250;
		public override void putByteArray(java.lang.String arg0, byte[] arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.prefs.Preferences_.staticClass, "putByteArray", "(Ljava/lang/String;[B)V", ref global::java.util.prefs.Preferences_._putByteArray28250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getByteArray28251;
		public override byte[] getByteArray(java.lang.String arg0, byte[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.util.prefs.Preferences_.staticClass, "getByteArray", "(Ljava/lang/String;[B)[B", ref global::java.util.prefs.Preferences_._getByteArray28251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _node28252;
		public override global::java.util.prefs.Preferences node(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.prefs.Preferences_.staticClass, "node", "(Ljava/lang/String;)Ljava/util/prefs/Preferences;", ref global::java.util.prefs.Preferences_._node28252, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.prefs.Preferences;
		}
		internal static global::MonoJavaBridge.MethodId _absolutePath28253;
		public override global::java.lang.String absolutePath()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.prefs.Preferences_.staticClass, "absolutePath", "()Ljava/lang/String;", ref global::java.util.prefs.Preferences_._absolutePath28253) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _childrenNames28254;
		public override global::java.lang.String[] childrenNames()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::java.util.prefs.Preferences_.staticClass, "childrenNames", "()[Ljava/lang/String;", ref global::java.util.prefs.Preferences_._childrenNames28254) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _nodeExists28255;
		public override bool nodeExists(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.prefs.Preferences_.staticClass, "nodeExists", "(Ljava/lang/String;)Z", ref global::java.util.prefs.Preferences_._nodeExists28255, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeNode28256;
		public override void removeNode()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.prefs.Preferences_.staticClass, "removeNode", "()V", ref global::java.util.prefs.Preferences_._removeNode28256);
		}
		internal static global::MonoJavaBridge.MethodId _isUserNode28257;
		public override bool isUserNode()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.prefs.Preferences_.staticClass, "isUserNode", "()Z", ref global::java.util.prefs.Preferences_._isUserNode28257);
		}
		internal static global::MonoJavaBridge.MethodId _addPreferenceChangeListener28258;
		public override void addPreferenceChangeListener(java.util.prefs.PreferenceChangeListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.prefs.Preferences_.staticClass, "addPreferenceChangeListener", "(Ljava/util/prefs/PreferenceChangeListener;)V", ref global::java.util.prefs.Preferences_._addPreferenceChangeListener28258, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removePreferenceChangeListener28259;
		public override void removePreferenceChangeListener(java.util.prefs.PreferenceChangeListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.prefs.Preferences_.staticClass, "removePreferenceChangeListener", "(Ljava/util/prefs/PreferenceChangeListener;)V", ref global::java.util.prefs.Preferences_._removePreferenceChangeListener28259, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addNodeChangeListener28260;
		public override void addNodeChangeListener(java.util.prefs.NodeChangeListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.prefs.Preferences_.staticClass, "addNodeChangeListener", "(Ljava/util/prefs/NodeChangeListener;)V", ref global::java.util.prefs.Preferences_._addNodeChangeListener28260, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeNodeChangeListener28261;
		public override void removeNodeChangeListener(java.util.prefs.NodeChangeListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.prefs.Preferences_.staticClass, "removeNodeChangeListener", "(Ljava/util/prefs/NodeChangeListener;)V", ref global::java.util.prefs.Preferences_._removeNodeChangeListener28261, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _exportNode28262;
		public override void exportNode(java.io.OutputStream arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.prefs.Preferences_.staticClass, "exportNode", "(Ljava/io/OutputStream;)V", ref global::java.util.prefs.Preferences_._exportNode28262, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _exportSubtree28263;
		public override void exportSubtree(java.io.OutputStream arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.prefs.Preferences_.staticClass, "exportSubtree", "(Ljava/io/OutputStream;)V", ref global::java.util.prefs.Preferences_._exportSubtree28263, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static Preferences_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.prefs.Preferences_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/prefs/Preferences"));
		}
		internal static void InitJNI()
		{
		}
	}
}
