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
		internal static global::MonoJavaBridge.MethodId _name28186;
		public abstract global::java.lang.String name();
		internal static global::MonoJavaBridge.MethodId _parent28187;
		public abstract global::java.util.prefs.Preferences parent();
		internal static global::MonoJavaBridge.MethodId _get28188;
		public abstract global::java.lang.String get(java.lang.String arg0, java.lang.String arg1);
		internal static global::MonoJavaBridge.MethodId _put28189;
		public abstract void put(java.lang.String arg0, java.lang.String arg1);
		internal static global::MonoJavaBridge.MethodId _toString28190;
		public abstract global::java.lang.String toString();
		internal static global::MonoJavaBridge.MethodId _getBoolean28191;
		public abstract bool getBoolean(java.lang.String arg0, bool arg1);
		internal static global::MonoJavaBridge.MethodId _putBoolean28192;
		public abstract void putBoolean(java.lang.String arg0, bool arg1);
		internal static global::MonoJavaBridge.MethodId _getInt28193;
		public abstract int getInt(java.lang.String arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _putInt28194;
		public abstract void putInt(java.lang.String arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _getLong28195;
		public abstract long getLong(java.lang.String arg0, long arg1);
		internal static global::MonoJavaBridge.MethodId _putLong28196;
		public abstract void putLong(java.lang.String arg0, long arg1);
		internal static global::MonoJavaBridge.MethodId _getFloat28197;
		public abstract float getFloat(java.lang.String arg0, float arg1);
		internal static global::MonoJavaBridge.MethodId _putFloat28198;
		public abstract void putFloat(java.lang.String arg0, float arg1);
		internal static global::MonoJavaBridge.MethodId _getDouble28199;
		public abstract double getDouble(java.lang.String arg0, double arg1);
		internal static global::MonoJavaBridge.MethodId _putDouble28200;
		public abstract void putDouble(java.lang.String arg0, double arg1);
		internal static global::MonoJavaBridge.MethodId _clear28201;
		public abstract void clear();
		internal static global::MonoJavaBridge.MethodId _remove28202;
		public abstract void remove(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _keys28203;
		public abstract global::java.lang.String[] keys();
		internal static global::MonoJavaBridge.MethodId _flush28204;
		public abstract void flush();
		internal static global::MonoJavaBridge.MethodId _sync28205;
		public abstract void sync();
		internal static global::MonoJavaBridge.MethodId _putByteArray28206;
		public abstract void putByteArray(java.lang.String arg0, byte[] arg1);
		internal static global::MonoJavaBridge.MethodId _getByteArray28207;
		public abstract byte[] getByteArray(java.lang.String arg0, byte[] arg1);
		internal static global::MonoJavaBridge.MethodId _node28208;
		public abstract global::java.util.prefs.Preferences node(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _absolutePath28209;
		public abstract global::java.lang.String absolutePath();
		internal static global::MonoJavaBridge.MethodId _childrenNames28210;
		public abstract global::java.lang.String[] childrenNames();
		internal static global::MonoJavaBridge.MethodId _nodeExists28211;
		public abstract bool nodeExists(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _removeNode28212;
		public abstract void removeNode();
		internal static global::MonoJavaBridge.MethodId _isUserNode28213;
		public abstract bool isUserNode();
		internal static global::MonoJavaBridge.MethodId _addPreferenceChangeListener28214;
		public abstract void addPreferenceChangeListener(java.util.prefs.PreferenceChangeListener arg0);
		internal static global::MonoJavaBridge.MethodId _removePreferenceChangeListener28215;
		public abstract void removePreferenceChangeListener(java.util.prefs.PreferenceChangeListener arg0);
		internal static global::MonoJavaBridge.MethodId _addNodeChangeListener28216;
		public abstract void addNodeChangeListener(java.util.prefs.NodeChangeListener arg0);
		internal static global::MonoJavaBridge.MethodId _removeNodeChangeListener28217;
		public abstract void removeNodeChangeListener(java.util.prefs.NodeChangeListener arg0);
		internal static global::MonoJavaBridge.MethodId _exportNode28218;
		public abstract void exportNode(java.io.OutputStream arg0);
		internal static global::MonoJavaBridge.MethodId _exportSubtree28219;
		public abstract void exportSubtree(java.io.OutputStream arg0);
		internal static global::MonoJavaBridge.MethodId _userNodeForPackage28220;
		public static global::java.util.prefs.Preferences userNodeForPackage(java.lang.Class arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.prefs.Preferences.staticClass, global::java.util.prefs.Preferences._userNodeForPackage28220, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.prefs.Preferences;
		}
		internal static global::MonoJavaBridge.MethodId _systemNodeForPackage28221;
		public static global::java.util.prefs.Preferences systemNodeForPackage(java.lang.Class arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.prefs.Preferences.staticClass, global::java.util.prefs.Preferences._systemNodeForPackage28221, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.prefs.Preferences;
		}
		internal static global::MonoJavaBridge.MethodId _userRoot28222;
		public static global::java.util.prefs.Preferences userRoot()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.prefs.Preferences.staticClass, global::java.util.prefs.Preferences._userRoot28222)) as java.util.prefs.Preferences;
		}
		internal static global::MonoJavaBridge.MethodId _systemRoot28223;
		public static global::java.util.prefs.Preferences systemRoot()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.prefs.Preferences.staticClass, global::java.util.prefs.Preferences._systemRoot28223)) as java.util.prefs.Preferences;
		}
		internal static global::MonoJavaBridge.MethodId _importPreferences28224;
		public static void importPreferences(java.io.InputStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.prefs.Preferences.staticClass, global::java.util.prefs.Preferences._importPreferences28224, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Preferences28225;
		protected Preferences() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.prefs.Preferences.staticClass, global::java.util.prefs.Preferences._Preferences28225);
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
			global::java.util.prefs.Preferences._name28186 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "name", "()Ljava/lang/String;");
			global::java.util.prefs.Preferences._parent28187 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "parent", "()Ljava/util/prefs/Preferences;");
			global::java.util.prefs.Preferences._get28188 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "get", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::java.util.prefs.Preferences._put28189 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "put", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.util.prefs.Preferences._toString28190 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.prefs.Preferences._getBoolean28191 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "getBoolean", "(Ljava/lang/String;Z)Z");
			global::java.util.prefs.Preferences._putBoolean28192 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "putBoolean", "(Ljava/lang/String;Z)V");
			global::java.util.prefs.Preferences._getInt28193 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "getInt", "(Ljava/lang/String;I)I");
			global::java.util.prefs.Preferences._putInt28194 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "putInt", "(Ljava/lang/String;I)V");
			global::java.util.prefs.Preferences._getLong28195 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "getLong", "(Ljava/lang/String;J)J");
			global::java.util.prefs.Preferences._putLong28196 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "putLong", "(Ljava/lang/String;J)V");
			global::java.util.prefs.Preferences._getFloat28197 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "getFloat", "(Ljava/lang/String;F)F");
			global::java.util.prefs.Preferences._putFloat28198 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "putFloat", "(Ljava/lang/String;F)V");
			global::java.util.prefs.Preferences._getDouble28199 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "getDouble", "(Ljava/lang/String;D)D");
			global::java.util.prefs.Preferences._putDouble28200 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "putDouble", "(Ljava/lang/String;D)V");
			global::java.util.prefs.Preferences._clear28201 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "clear", "()V");
			global::java.util.prefs.Preferences._remove28202 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "remove", "(Ljava/lang/String;)V");
			global::java.util.prefs.Preferences._keys28203 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "keys", "()[Ljava/lang/String;");
			global::java.util.prefs.Preferences._flush28204 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "flush", "()V");
			global::java.util.prefs.Preferences._sync28205 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "sync", "()V");
			global::java.util.prefs.Preferences._putByteArray28206 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "putByteArray", "(Ljava/lang/String;[B)V");
			global::java.util.prefs.Preferences._getByteArray28207 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "getByteArray", "(Ljava/lang/String;[B)[B");
			global::java.util.prefs.Preferences._node28208 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "node", "(Ljava/lang/String;)Ljava/util/prefs/Preferences;");
			global::java.util.prefs.Preferences._absolutePath28209 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "absolutePath", "()Ljava/lang/String;");
			global::java.util.prefs.Preferences._childrenNames28210 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "childrenNames", "()[Ljava/lang/String;");
			global::java.util.prefs.Preferences._nodeExists28211 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "nodeExists", "(Ljava/lang/String;)Z");
			global::java.util.prefs.Preferences._removeNode28212 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "removeNode", "()V");
			global::java.util.prefs.Preferences._isUserNode28213 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "isUserNode", "()Z");
			global::java.util.prefs.Preferences._addPreferenceChangeListener28214 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "addPreferenceChangeListener", "(Ljava/util/prefs/PreferenceChangeListener;)V");
			global::java.util.prefs.Preferences._removePreferenceChangeListener28215 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "removePreferenceChangeListener", "(Ljava/util/prefs/PreferenceChangeListener;)V");
			global::java.util.prefs.Preferences._addNodeChangeListener28216 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "addNodeChangeListener", "(Ljava/util/prefs/NodeChangeListener;)V");
			global::java.util.prefs.Preferences._removeNodeChangeListener28217 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "removeNodeChangeListener", "(Ljava/util/prefs/NodeChangeListener;)V");
			global::java.util.prefs.Preferences._exportNode28218 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "exportNode", "(Ljava/io/OutputStream;)V");
			global::java.util.prefs.Preferences._exportSubtree28219 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "exportSubtree", "(Ljava/io/OutputStream;)V");
			global::java.util.prefs.Preferences._userNodeForPackage28220 = @__env.GetStaticMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "userNodeForPackage", "(Ljava/lang/Class;)Ljava/util/prefs/Preferences;");
			global::java.util.prefs.Preferences._systemNodeForPackage28221 = @__env.GetStaticMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "systemNodeForPackage", "(Ljava/lang/Class;)Ljava/util/prefs/Preferences;");
			global::java.util.prefs.Preferences._userRoot28222 = @__env.GetStaticMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "userRoot", "()Ljava/util/prefs/Preferences;");
			global::java.util.prefs.Preferences._systemRoot28223 = @__env.GetStaticMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "systemRoot", "()Ljava/util/prefs/Preferences;");
			global::java.util.prefs.Preferences._importPreferences28224 = @__env.GetStaticMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "importPreferences", "(Ljava/io/InputStream;)V");
			global::java.util.prefs.Preferences._Preferences28225 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.prefs.Preferences))]
	internal sealed partial class Preferences_ : java.util.prefs.Preferences
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Preferences_()
		{
			InitJNI();
		}
		internal Preferences_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _name28229;
		public override global::java.lang.String name()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.Preferences_._name28229)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._name28229)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _parent28230;
		public override global::java.util.prefs.Preferences parent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.Preferences_._parent28230)) as java.util.prefs.Preferences;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._parent28230)) as java.util.prefs.Preferences;
		}
		internal static global::MonoJavaBridge.MethodId _get28231;
		public override global::java.lang.String get(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.Preferences_._get28231, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._get28231, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _put28232;
		public override void put(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_._put28232, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._put28232, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _toString28233;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.Preferences_._toString28233)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._toString28233)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getBoolean28234;
		public override bool getBoolean(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.prefs.Preferences_._getBoolean28234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._getBoolean28234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putBoolean28235;
		public override void putBoolean(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_._putBoolean28235, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._putBoolean28235, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getInt28236;
		public override int getInt(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.prefs.Preferences_._getInt28236, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._getInt28236, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putInt28237;
		public override void putInt(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_._putInt28237, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._putInt28237, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getLong28238;
		public override long getLong(java.lang.String arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.prefs.Preferences_._getLong28238, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._getLong28238, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putLong28239;
		public override void putLong(java.lang.String arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_._putLong28239, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._putLong28239, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFloat28240;
		public override float getFloat(java.lang.String arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.util.prefs.Preferences_._getFloat28240, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._getFloat28240, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putFloat28241;
		public override void putFloat(java.lang.String arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_._putFloat28241, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._putFloat28241, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getDouble28242;
		public override double getDouble(java.lang.String arg0, double arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.util.prefs.Preferences_._getDouble28242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._getDouble28242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putDouble28243;
		public override void putDouble(java.lang.String arg0, double arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_._putDouble28243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._putDouble28243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _clear28244;
		public override void clear()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_._clear28244);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._clear28244);
		}
		internal static global::MonoJavaBridge.MethodId _remove28245;
		public override void remove(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_._remove28245, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._remove28245, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _keys28246;
		public override global::java.lang.String[] keys()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.Preferences_._keys28246)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._keys28246)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _flush28247;
		public override void flush()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_._flush28247);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._flush28247);
		}
		internal static global::MonoJavaBridge.MethodId _sync28248;
		public override void sync()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_._sync28248);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._sync28248);
		}
		internal static global::MonoJavaBridge.MethodId _putByteArray28249;
		public override void putByteArray(java.lang.String arg0, byte[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_._putByteArray28249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._putByteArray28249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getByteArray28250;
		public override byte[] getByteArray(java.lang.String arg0, byte[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.Preferences_._getByteArray28250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._getByteArray28250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _node28251;
		public override global::java.util.prefs.Preferences node(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.Preferences_._node28251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.prefs.Preferences;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._node28251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.prefs.Preferences;
		}
		internal static global::MonoJavaBridge.MethodId _absolutePath28252;
		public override global::java.lang.String absolutePath()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.Preferences_._absolutePath28252)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._absolutePath28252)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _childrenNames28253;
		public override global::java.lang.String[] childrenNames()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.Preferences_._childrenNames28253)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._childrenNames28253)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _nodeExists28254;
		public override bool nodeExists(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.prefs.Preferences_._nodeExists28254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._nodeExists28254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeNode28255;
		public override void removeNode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_._removeNode28255);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._removeNode28255);
		}
		internal static global::MonoJavaBridge.MethodId _isUserNode28256;
		public override bool isUserNode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.prefs.Preferences_._isUserNode28256);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._isUserNode28256);
		}
		internal static global::MonoJavaBridge.MethodId _addPreferenceChangeListener28257;
		public override void addPreferenceChangeListener(java.util.prefs.PreferenceChangeListener arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_._addPreferenceChangeListener28257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._addPreferenceChangeListener28257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removePreferenceChangeListener28258;
		public override void removePreferenceChangeListener(java.util.prefs.PreferenceChangeListener arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_._removePreferenceChangeListener28258, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._removePreferenceChangeListener28258, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addNodeChangeListener28259;
		public override void addNodeChangeListener(java.util.prefs.NodeChangeListener arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_._addNodeChangeListener28259, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._addNodeChangeListener28259, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeNodeChangeListener28260;
		public override void removeNodeChangeListener(java.util.prefs.NodeChangeListener arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_._removeNodeChangeListener28260, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._removeNodeChangeListener28260, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _exportNode28261;
		public override void exportNode(java.io.OutputStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_._exportNode28261, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._exportNode28261, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _exportSubtree28262;
		public override void exportSubtree(java.io.OutputStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_._exportSubtree28262, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.Preferences_.staticClass, global::java.util.prefs.Preferences_._exportSubtree28262, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.prefs.Preferences_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/prefs/Preferences"));
			global::java.util.prefs.Preferences_._name28229 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "name", "()Ljava/lang/String;");
			global::java.util.prefs.Preferences_._parent28230 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "parent", "()Ljava/util/prefs/Preferences;");
			global::java.util.prefs.Preferences_._get28231 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "get", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::java.util.prefs.Preferences_._put28232 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "put", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.util.prefs.Preferences_._toString28233 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.prefs.Preferences_._getBoolean28234 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "getBoolean", "(Ljava/lang/String;Z)Z");
			global::java.util.prefs.Preferences_._putBoolean28235 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "putBoolean", "(Ljava/lang/String;Z)V");
			global::java.util.prefs.Preferences_._getInt28236 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "getInt", "(Ljava/lang/String;I)I");
			global::java.util.prefs.Preferences_._putInt28237 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "putInt", "(Ljava/lang/String;I)V");
			global::java.util.prefs.Preferences_._getLong28238 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "getLong", "(Ljava/lang/String;J)J");
			global::java.util.prefs.Preferences_._putLong28239 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "putLong", "(Ljava/lang/String;J)V");
			global::java.util.prefs.Preferences_._getFloat28240 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "getFloat", "(Ljava/lang/String;F)F");
			global::java.util.prefs.Preferences_._putFloat28241 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "putFloat", "(Ljava/lang/String;F)V");
			global::java.util.prefs.Preferences_._getDouble28242 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "getDouble", "(Ljava/lang/String;D)D");
			global::java.util.prefs.Preferences_._putDouble28243 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "putDouble", "(Ljava/lang/String;D)V");
			global::java.util.prefs.Preferences_._clear28244 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "clear", "()V");
			global::java.util.prefs.Preferences_._remove28245 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "remove", "(Ljava/lang/String;)V");
			global::java.util.prefs.Preferences_._keys28246 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "keys", "()[Ljava/lang/String;");
			global::java.util.prefs.Preferences_._flush28247 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "flush", "()V");
			global::java.util.prefs.Preferences_._sync28248 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "sync", "()V");
			global::java.util.prefs.Preferences_._putByteArray28249 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "putByteArray", "(Ljava/lang/String;[B)V");
			global::java.util.prefs.Preferences_._getByteArray28250 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "getByteArray", "(Ljava/lang/String;[B)[B");
			global::java.util.prefs.Preferences_._node28251 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "node", "(Ljava/lang/String;)Ljava/util/prefs/Preferences;");
			global::java.util.prefs.Preferences_._absolutePath28252 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "absolutePath", "()Ljava/lang/String;");
			global::java.util.prefs.Preferences_._childrenNames28253 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "childrenNames", "()[Ljava/lang/String;");
			global::java.util.prefs.Preferences_._nodeExists28254 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "nodeExists", "(Ljava/lang/String;)Z");
			global::java.util.prefs.Preferences_._removeNode28255 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "removeNode", "()V");
			global::java.util.prefs.Preferences_._isUserNode28256 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "isUserNode", "()Z");
			global::java.util.prefs.Preferences_._addPreferenceChangeListener28257 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "addPreferenceChangeListener", "(Ljava/util/prefs/PreferenceChangeListener;)V");
			global::java.util.prefs.Preferences_._removePreferenceChangeListener28258 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "removePreferenceChangeListener", "(Ljava/util/prefs/PreferenceChangeListener;)V");
			global::java.util.prefs.Preferences_._addNodeChangeListener28259 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "addNodeChangeListener", "(Ljava/util/prefs/NodeChangeListener;)V");
			global::java.util.prefs.Preferences_._removeNodeChangeListener28260 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "removeNodeChangeListener", "(Ljava/util/prefs/NodeChangeListener;)V");
			global::java.util.prefs.Preferences_._exportNode28261 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "exportNode", "(Ljava/io/OutputStream;)V");
			global::java.util.prefs.Preferences_._exportSubtree28262 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences_.staticClass, "exportSubtree", "(Ljava/io/OutputStream;)V");
		}
	}
}
