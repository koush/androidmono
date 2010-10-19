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
		internal static global::MonoJavaBridge.MethodId _name22205;
		public abstract global::java.lang.String name();
		internal static global::MonoJavaBridge.MethodId _parent22206;
		public abstract global::java.util.prefs.Preferences parent();
		internal static global::MonoJavaBridge.MethodId _get22207;
		public abstract global::java.lang.String get(java.lang.String arg0, java.lang.String arg1);
		internal static global::MonoJavaBridge.MethodId _put22208;
		public abstract void put(java.lang.String arg0, java.lang.String arg1);
		internal static global::MonoJavaBridge.MethodId _toString22209;
		public abstract global::java.lang.String toString();
		internal static global::MonoJavaBridge.MethodId _getBoolean22210;
		public abstract bool getBoolean(java.lang.String arg0, bool arg1);
		internal static global::MonoJavaBridge.MethodId _putBoolean22211;
		public abstract void putBoolean(java.lang.String arg0, bool arg1);
		internal static global::MonoJavaBridge.MethodId _getInt22212;
		public abstract int getInt(java.lang.String arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _putInt22213;
		public abstract void putInt(java.lang.String arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _getLong22214;
		public abstract long getLong(java.lang.String arg0, long arg1);
		internal static global::MonoJavaBridge.MethodId _putLong22215;
		public abstract void putLong(java.lang.String arg0, long arg1);
		internal static global::MonoJavaBridge.MethodId _getFloat22216;
		public abstract float getFloat(java.lang.String arg0, float arg1);
		internal static global::MonoJavaBridge.MethodId _putFloat22217;
		public abstract void putFloat(java.lang.String arg0, float arg1);
		internal static global::MonoJavaBridge.MethodId _getDouble22218;
		public abstract double getDouble(java.lang.String arg0, double arg1);
		internal static global::MonoJavaBridge.MethodId _putDouble22219;
		public abstract void putDouble(java.lang.String arg0, double arg1);
		internal static global::MonoJavaBridge.MethodId _clear22220;
		public abstract void clear();
		internal static global::MonoJavaBridge.MethodId _remove22221;
		public abstract void remove(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _keys22222;
		public abstract global::java.lang.String[] keys();
		internal static global::MonoJavaBridge.MethodId _flush22223;
		public abstract void flush();
		internal static global::MonoJavaBridge.MethodId _sync22224;
		public abstract void sync();
		internal static global::MonoJavaBridge.MethodId _putByteArray22225;
		public abstract void putByteArray(java.lang.String arg0, byte[] arg1);
		internal static global::MonoJavaBridge.MethodId _getByteArray22226;
		public abstract byte[] getByteArray(java.lang.String arg0, byte[] arg1);
		internal static global::MonoJavaBridge.MethodId _node22227;
		public abstract global::java.util.prefs.Preferences node(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _absolutePath22228;
		public abstract global::java.lang.String absolutePath();
		internal static global::MonoJavaBridge.MethodId _childrenNames22229;
		public abstract global::java.lang.String[] childrenNames();
		internal static global::MonoJavaBridge.MethodId _nodeExists22230;
		public abstract bool nodeExists(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _removeNode22231;
		public abstract void removeNode();
		internal static global::MonoJavaBridge.MethodId _isUserNode22232;
		public abstract bool isUserNode();
		internal static global::MonoJavaBridge.MethodId _addPreferenceChangeListener22233;
		public abstract void addPreferenceChangeListener(java.util.prefs.PreferenceChangeListener arg0);
		internal static global::MonoJavaBridge.MethodId _removePreferenceChangeListener22234;
		public abstract void removePreferenceChangeListener(java.util.prefs.PreferenceChangeListener arg0);
		internal static global::MonoJavaBridge.MethodId _addNodeChangeListener22235;
		public abstract void addNodeChangeListener(java.util.prefs.NodeChangeListener arg0);
		internal static global::MonoJavaBridge.MethodId _removeNodeChangeListener22236;
		public abstract void removeNodeChangeListener(java.util.prefs.NodeChangeListener arg0);
		internal static global::MonoJavaBridge.MethodId _exportNode22237;
		public abstract void exportNode(java.io.OutputStream arg0);
		internal static global::MonoJavaBridge.MethodId _exportSubtree22238;
		public abstract void exportSubtree(java.io.OutputStream arg0);
		internal static global::MonoJavaBridge.MethodId _userNodeForPackage22239;
		public static global::java.util.prefs.Preferences userNodeForPackage(java.lang.Class arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.prefs.Preferences.staticClass, global::java.util.prefs.Preferences._userNodeForPackage22239, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.prefs.Preferences;
		}
		internal static global::MonoJavaBridge.MethodId _systemNodeForPackage22240;
		public static global::java.util.prefs.Preferences systemNodeForPackage(java.lang.Class arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.prefs.Preferences.staticClass, global::java.util.prefs.Preferences._systemNodeForPackage22240, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.prefs.Preferences;
		}
		internal static global::MonoJavaBridge.MethodId _userRoot22241;
		public static global::java.util.prefs.Preferences userRoot() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.prefs.Preferences.staticClass, global::java.util.prefs.Preferences._userRoot22241)) as java.util.prefs.Preferences;
		}
		internal static global::MonoJavaBridge.MethodId _systemRoot22242;
		public static global::java.util.prefs.Preferences systemRoot() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.prefs.Preferences.staticClass, global::java.util.prefs.Preferences._systemRoot22242)) as java.util.prefs.Preferences;
		}
		internal static global::MonoJavaBridge.MethodId _importPreferences22243;
		public static void importPreferences(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.prefs.Preferences.staticClass, global::java.util.prefs.Preferences._importPreferences22243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Preferences22244;
		protected Preferences()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.prefs.Preferences.staticClass, global::java.util.prefs.Preferences._Preferences22244);
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
			global::java.util.prefs.Preferences._name22205 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "name", "()Ljava/lang/String;");
			global::java.util.prefs.Preferences._parent22206 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "parent", "()Ljava/util/prefs/Preferences;");
			global::java.util.prefs.Preferences._get22207 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "get", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::java.util.prefs.Preferences._put22208 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "put", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.util.prefs.Preferences._toString22209 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.prefs.Preferences._getBoolean22210 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "getBoolean", "(Ljava/lang/String;Z)Z");
			global::java.util.prefs.Preferences._putBoolean22211 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "putBoolean", "(Ljava/lang/String;Z)V");
			global::java.util.prefs.Preferences._getInt22212 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "getInt", "(Ljava/lang/String;I)I");
			global::java.util.prefs.Preferences._putInt22213 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "putInt", "(Ljava/lang/String;I)V");
			global::java.util.prefs.Preferences._getLong22214 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "getLong", "(Ljava/lang/String;J)J");
			global::java.util.prefs.Preferences._putLong22215 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "putLong", "(Ljava/lang/String;J)V");
			global::java.util.prefs.Preferences._getFloat22216 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "getFloat", "(Ljava/lang/String;F)F");
			global::java.util.prefs.Preferences._putFloat22217 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "putFloat", "(Ljava/lang/String;F)V");
			global::java.util.prefs.Preferences._getDouble22218 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "getDouble", "(Ljava/lang/String;D)D");
			global::java.util.prefs.Preferences._putDouble22219 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "putDouble", "(Ljava/lang/String;D)V");
			global::java.util.prefs.Preferences._clear22220 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "clear", "()V");
			global::java.util.prefs.Preferences._remove22221 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "remove", "(Ljava/lang/String;)V");
			global::java.util.prefs.Preferences._keys22222 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "keys", "()[Ljava/lang/String;");
			global::java.util.prefs.Preferences._flush22223 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "flush", "()V");
			global::java.util.prefs.Preferences._sync22224 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "sync", "()V");
			global::java.util.prefs.Preferences._putByteArray22225 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "putByteArray", "(Ljava/lang/String;[B)V");
			global::java.util.prefs.Preferences._getByteArray22226 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "getByteArray", "(Ljava/lang/String;[B)[B");
			global::java.util.prefs.Preferences._node22227 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "node", "(Ljava/lang/String;)Ljava/util/prefs/Preferences;");
			global::java.util.prefs.Preferences._absolutePath22228 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "absolutePath", "()Ljava/lang/String;");
			global::java.util.prefs.Preferences._childrenNames22229 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "childrenNames", "()[Ljava/lang/String;");
			global::java.util.prefs.Preferences._nodeExists22230 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "nodeExists", "(Ljava/lang/String;)Z");
			global::java.util.prefs.Preferences._removeNode22231 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "removeNode", "()V");
			global::java.util.prefs.Preferences._isUserNode22232 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "isUserNode", "()Z");
			global::java.util.prefs.Preferences._addPreferenceChangeListener22233 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "addPreferenceChangeListener", "(Ljava/util/prefs/PreferenceChangeListener;)V");
			global::java.util.prefs.Preferences._removePreferenceChangeListener22234 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "removePreferenceChangeListener", "(Ljava/util/prefs/PreferenceChangeListener;)V");
			global::java.util.prefs.Preferences._addNodeChangeListener22235 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "addNodeChangeListener", "(Ljava/util/prefs/NodeChangeListener;)V");
			global::java.util.prefs.Preferences._removeNodeChangeListener22236 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "removeNodeChangeListener", "(Ljava/util/prefs/NodeChangeListener;)V");
			global::java.util.prefs.Preferences._exportNode22237 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "exportNode", "(Ljava/io/OutputStream;)V");
			global::java.util.prefs.Preferences._exportSubtree22238 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "exportSubtree", "(Ljava/io/OutputStream;)V");
			global::java.util.prefs.Preferences._userNodeForPackage22239 = @__env.GetStaticMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "userNodeForPackage", "(Ljava/lang/Class;)Ljava/util/prefs/Preferences;");
			global::java.util.prefs.Preferences._systemNodeForPackage22240 = @__env.GetStaticMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "systemNodeForPackage", "(Ljava/lang/Class;)Ljava/util/prefs/Preferences;");
			global::java.util.prefs.Preferences._userRoot22241 = @__env.GetStaticMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "userRoot", "()Ljava/util/prefs/Preferences;");
			global::java.util.prefs.Preferences._systemRoot22242 = @__env.GetStaticMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "systemRoot", "()Ljava/util/prefs/Preferences;");
			global::java.util.prefs.Preferences._importPreferences22243 = @__env.GetStaticMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "importPreferences", "(Ljava/io/InputStream;)V");
			global::java.util.prefs.Preferences._Preferences22244 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "<init>", "()V");
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
		internal static global::MonoJavaBridge.MethodId _name22245;
		public override global::java.lang.String name() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.Preferences_._name22245)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._name22245)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _parent22246;
		public override global::java.util.prefs.Preferences parent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.Preferences_._parent22246)) as java.util.prefs.Preferences;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._parent22246)) as java.util.prefs.Preferences;
		}
		internal static global::MonoJavaBridge.MethodId _get22247;
		public override global::java.lang.String get(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.Preferences_._get22247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._get22247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _put22248;
		public override void put(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_._put22248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._put22248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _toString22249;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.Preferences_._toString22249)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._toString22249)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getBoolean22250;
		public override bool getBoolean(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.prefs.Preferences_._getBoolean22250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._getBoolean22250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putBoolean22251;
		public override void putBoolean(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_._putBoolean22251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._putBoolean22251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getInt22252;
		public override int getInt(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.prefs.Preferences_._getInt22252, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._getInt22252, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putInt22253;
		public override void putInt(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_._putInt22253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._putInt22253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getLong22254;
		public override long getLong(java.lang.String arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.prefs.Preferences_._getLong22254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._getLong22254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putLong22255;
		public override void putLong(java.lang.String arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_._putLong22255, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._putLong22255, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFloat22256;
		public override float getFloat(java.lang.String arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.util.prefs.Preferences_._getFloat22256, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._getFloat22256, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putFloat22257;
		public override void putFloat(java.lang.String arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_._putFloat22257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._putFloat22257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getDouble22258;
		public override double getDouble(java.lang.String arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.util.prefs.Preferences_._getDouble22258, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._getDouble22258, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putDouble22259;
		public override void putDouble(java.lang.String arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_._putDouble22259, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._putDouble22259, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _clear22260;
		public override void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_._clear22260);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._clear22260);
		}
		internal static global::MonoJavaBridge.MethodId _remove22261;
		public override void remove(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_._remove22261, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._remove22261, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _keys22262;
		public override global::java.lang.String[] keys() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.Preferences_._keys22262)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._keys22262)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _flush22263;
		public override void flush() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_._flush22263);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._flush22263);
		}
		internal static global::MonoJavaBridge.MethodId _sync22264;
		public override void sync() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_._sync22264);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._sync22264);
		}
		internal static global::MonoJavaBridge.MethodId _putByteArray22265;
		public override void putByteArray(java.lang.String arg0, byte[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_._putByteArray22265, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._putByteArray22265, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getByteArray22266;
		public override byte[] getByteArray(java.lang.String arg0, byte[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.Preferences_._getByteArray22266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._getByteArray22266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _node22267;
		public override global::java.util.prefs.Preferences node(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.Preferences_._node22267, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.prefs.Preferences;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._node22267, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.prefs.Preferences;
		}
		internal static global::MonoJavaBridge.MethodId _absolutePath22268;
		public override global::java.lang.String absolutePath() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.Preferences_._absolutePath22268)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._absolutePath22268)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _childrenNames22269;
		public override global::java.lang.String[] childrenNames() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.Preferences_._childrenNames22269)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._childrenNames22269)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _nodeExists22270;
		public override bool nodeExists(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.prefs.Preferences_._nodeExists22270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._nodeExists22270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeNode22271;
		public override void removeNode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_._removeNode22271);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._removeNode22271);
		}
		internal static global::MonoJavaBridge.MethodId _isUserNode22272;
		public override bool isUserNode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.prefs.Preferences_._isUserNode22272);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._isUserNode22272);
		}
		internal static global::MonoJavaBridge.MethodId _addPreferenceChangeListener22273;
		public override void addPreferenceChangeListener(java.util.prefs.PreferenceChangeListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_._addPreferenceChangeListener22273, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._addPreferenceChangeListener22273, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removePreferenceChangeListener22274;
		public override void removePreferenceChangeListener(java.util.prefs.PreferenceChangeListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_._removePreferenceChangeListener22274, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._removePreferenceChangeListener22274, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addNodeChangeListener22275;
		public override void addNodeChangeListener(java.util.prefs.NodeChangeListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_._addNodeChangeListener22275, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._addNodeChangeListener22275, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeNodeChangeListener22276;
		public override void removeNodeChangeListener(java.util.prefs.NodeChangeListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_._removeNodeChangeListener22276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._removeNodeChangeListener22276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _exportNode22277;
		public override void exportNode(java.io.OutputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_._exportNode22277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._exportNode22277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _exportSubtree22278;
		public override void exportSubtree(java.io.OutputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_._exportSubtree22278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._exportSubtree22278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.prefs.Preferences_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/prefs/Preferences"));
			global::java.util.prefs.Preferences_._name22245 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "name", "()Ljava/lang/String;");
			global::java.util.prefs.Preferences_._parent22246 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "parent", "()Ljava/util/prefs/Preferences;");
			global::java.util.prefs.Preferences_._get22247 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "get", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::java.util.prefs.Preferences_._put22248 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "put", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.util.prefs.Preferences_._toString22249 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.prefs.Preferences_._getBoolean22250 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "getBoolean", "(Ljava/lang/String;Z)Z");
			global::java.util.prefs.Preferences_._putBoolean22251 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "putBoolean", "(Ljava/lang/String;Z)V");
			global::java.util.prefs.Preferences_._getInt22252 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "getInt", "(Ljava/lang/String;I)I");
			global::java.util.prefs.Preferences_._putInt22253 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "putInt", "(Ljava/lang/String;I)V");
			global::java.util.prefs.Preferences_._getLong22254 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "getLong", "(Ljava/lang/String;J)J");
			global::java.util.prefs.Preferences_._putLong22255 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "putLong", "(Ljava/lang/String;J)V");
			global::java.util.prefs.Preferences_._getFloat22256 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "getFloat", "(Ljava/lang/String;F)F");
			global::java.util.prefs.Preferences_._putFloat22257 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "putFloat", "(Ljava/lang/String;F)V");
			global::java.util.prefs.Preferences_._getDouble22258 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "getDouble", "(Ljava/lang/String;D)D");
			global::java.util.prefs.Preferences_._putDouble22259 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "putDouble", "(Ljava/lang/String;D)V");
			global::java.util.prefs.Preferences_._clear22260 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "clear", "()V");
			global::java.util.prefs.Preferences_._remove22261 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "remove", "(Ljava/lang/String;)V");
			global::java.util.prefs.Preferences_._keys22262 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "keys", "()[Ljava/lang/String;");
			global::java.util.prefs.Preferences_._flush22263 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "flush", "()V");
			global::java.util.prefs.Preferences_._sync22264 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "sync", "()V");
			global::java.util.prefs.Preferences_._putByteArray22265 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "putByteArray", "(Ljava/lang/String;[B)V");
			global::java.util.prefs.Preferences_._getByteArray22266 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "getByteArray", "(Ljava/lang/String;[B)[B");
			global::java.util.prefs.Preferences_._node22267 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "node", "(Ljava/lang/String;)Ljava/util/prefs/Preferences;");
			global::java.util.prefs.Preferences_._absolutePath22268 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "absolutePath", "()Ljava/lang/String;");
			global::java.util.prefs.Preferences_._childrenNames22269 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "childrenNames", "()[Ljava/lang/String;");
			global::java.util.prefs.Preferences_._nodeExists22270 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "nodeExists", "(Ljava/lang/String;)Z");
			global::java.util.prefs.Preferences_._removeNode22271 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "removeNode", "()V");
			global::java.util.prefs.Preferences_._isUserNode22272 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "isUserNode", "()Z");
			global::java.util.prefs.Preferences_._addPreferenceChangeListener22273 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "addPreferenceChangeListener", "(Ljava/util/prefs/PreferenceChangeListener;)V");
			global::java.util.prefs.Preferences_._removePreferenceChangeListener22274 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "removePreferenceChangeListener", "(Ljava/util/prefs/PreferenceChangeListener;)V");
			global::java.util.prefs.Preferences_._addNodeChangeListener22275 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "addNodeChangeListener", "(Ljava/util/prefs/NodeChangeListener;)V");
			global::java.util.prefs.Preferences_._removeNodeChangeListener22276 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "removeNodeChangeListener", "(Ljava/util/prefs/NodeChangeListener;)V");
			global::java.util.prefs.Preferences_._exportNode22277 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "exportNode", "(Ljava/io/OutputStream;)V");
			global::java.util.prefs.Preferences_._exportSubtree22278 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "exportSubtree", "(Ljava/io/OutputStream;)V");
		}
	}
}
