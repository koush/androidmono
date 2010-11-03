namespace java.util.prefs
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.prefs.Preferences_))]
	public abstract partial class Preferences : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Preferences(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract global::java.lang.String name();
		private static global::MonoJavaBridge.MethodId _m1;
		public abstract global::java.util.prefs.Preferences parent();
		private static global::MonoJavaBridge.MethodId _m2;
		public abstract global::java.lang.String get(java.lang.String arg0, java.lang.String arg1);
		private static global::MonoJavaBridge.MethodId _m3;
		public abstract void put(java.lang.String arg0, java.lang.String arg1);
		private static global::MonoJavaBridge.MethodId _m4;
		public abstract global::java.lang.String toString();
		private static global::MonoJavaBridge.MethodId _m5;
		public abstract bool getBoolean(java.lang.String arg0, bool arg1);
		private static global::MonoJavaBridge.MethodId _m6;
		public abstract void putBoolean(java.lang.String arg0, bool arg1);
		private static global::MonoJavaBridge.MethodId _m7;
		public abstract int getInt(java.lang.String arg0, int arg1);
		private static global::MonoJavaBridge.MethodId _m8;
		public abstract void putInt(java.lang.String arg0, int arg1);
		private static global::MonoJavaBridge.MethodId _m9;
		public abstract long getLong(java.lang.String arg0, long arg1);
		private static global::MonoJavaBridge.MethodId _m10;
		public abstract void putLong(java.lang.String arg0, long arg1);
		private static global::MonoJavaBridge.MethodId _m11;
		public abstract float getFloat(java.lang.String arg0, float arg1);
		private static global::MonoJavaBridge.MethodId _m12;
		public abstract void putFloat(java.lang.String arg0, float arg1);
		private static global::MonoJavaBridge.MethodId _m13;
		public abstract double getDouble(java.lang.String arg0, double arg1);
		private static global::MonoJavaBridge.MethodId _m14;
		public abstract void putDouble(java.lang.String arg0, double arg1);
		private static global::MonoJavaBridge.MethodId _m15;
		public abstract void clear();
		private static global::MonoJavaBridge.MethodId _m16;
		public abstract void remove(java.lang.String arg0);
		private static global::MonoJavaBridge.MethodId _m17;
		public abstract global::java.lang.String[] keys();
		private static global::MonoJavaBridge.MethodId _m18;
		public abstract void flush();
		private static global::MonoJavaBridge.MethodId _m19;
		public abstract void sync();
		private static global::MonoJavaBridge.MethodId _m20;
		public abstract void putByteArray(java.lang.String arg0, byte[] arg1);
		private static global::MonoJavaBridge.MethodId _m21;
		public abstract byte[] getByteArray(java.lang.String arg0, byte[] arg1);
		private static global::MonoJavaBridge.MethodId _m22;
		public abstract global::java.util.prefs.Preferences node(java.lang.String arg0);
		private static global::MonoJavaBridge.MethodId _m23;
		public abstract global::java.lang.String absolutePath();
		private static global::MonoJavaBridge.MethodId _m24;
		public abstract global::java.lang.String[] childrenNames();
		private static global::MonoJavaBridge.MethodId _m25;
		public abstract bool nodeExists(java.lang.String arg0);
		private static global::MonoJavaBridge.MethodId _m26;
		public abstract void removeNode();
		private static global::MonoJavaBridge.MethodId _m27;
		public abstract bool isUserNode();
		private static global::MonoJavaBridge.MethodId _m28;
		public abstract void addPreferenceChangeListener(java.util.prefs.PreferenceChangeListener arg0);
		private static global::MonoJavaBridge.MethodId _m29;
		public abstract void removePreferenceChangeListener(java.util.prefs.PreferenceChangeListener arg0);
		private static global::MonoJavaBridge.MethodId _m30;
		public abstract void addNodeChangeListener(java.util.prefs.NodeChangeListener arg0);
		private static global::MonoJavaBridge.MethodId _m31;
		public abstract void removeNodeChangeListener(java.util.prefs.NodeChangeListener arg0);
		private static global::MonoJavaBridge.MethodId _m32;
		public abstract void exportNode(java.io.OutputStream arg0);
		private static global::MonoJavaBridge.MethodId _m33;
		public abstract void exportSubtree(java.io.OutputStream arg0);
		private static global::MonoJavaBridge.MethodId _m34;
		public static global::java.util.prefs.Preferences userNodeForPackage(java.lang.Class arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.prefs.Preferences._m34.native == global::System.IntPtr.Zero)
				global::java.util.prefs.Preferences._m34 = @__env.GetStaticMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "userNodeForPackage", "(Ljava/lang/Class;)Ljava/util/prefs/Preferences;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.prefs.Preferences.staticClass, global::java.util.prefs.Preferences._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.prefs.Preferences;
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public static global::java.util.prefs.Preferences systemNodeForPackage(java.lang.Class arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.prefs.Preferences._m35.native == global::System.IntPtr.Zero)
				global::java.util.prefs.Preferences._m35 = @__env.GetStaticMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "systemNodeForPackage", "(Ljava/lang/Class;)Ljava/util/prefs/Preferences;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.prefs.Preferences.staticClass, global::java.util.prefs.Preferences._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.prefs.Preferences;
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public static global::java.util.prefs.Preferences userRoot()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.prefs.Preferences._m36.native == global::System.IntPtr.Zero)
				global::java.util.prefs.Preferences._m36 = @__env.GetStaticMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "userRoot", "()Ljava/util/prefs/Preferences;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.prefs.Preferences.staticClass, global::java.util.prefs.Preferences._m36)) as java.util.prefs.Preferences;
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public static global::java.util.prefs.Preferences systemRoot()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.prefs.Preferences._m37.native == global::System.IntPtr.Zero)
				global::java.util.prefs.Preferences._m37 = @__env.GetStaticMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "systemRoot", "()Ljava/util/prefs/Preferences;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.prefs.Preferences.staticClass, global::java.util.prefs.Preferences._m37)) as java.util.prefs.Preferences;
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public static void importPreferences(java.io.InputStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.prefs.Preferences._m38.native == global::System.IntPtr.Zero)
				global::java.util.prefs.Preferences._m38 = @__env.GetStaticMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "importPreferences", "(Ljava/io/InputStream;)V");
			@__env.CallStaticVoidMethod(java.util.prefs.Preferences.staticClass, global::java.util.prefs.Preferences._m38, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m39;
		protected Preferences() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.prefs.Preferences._m39.native == global::System.IntPtr.Zero)
				global::java.util.prefs.Preferences._m39 = @__env.GetMethodIDNoThrow(global::java.util.prefs.Preferences.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.prefs.Preferences.staticClass, global::java.util.prefs.Preferences._m39);
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
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.prefs.Preferences))]
	internal sealed partial class Preferences_ : java.util.prefs.Preferences
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Preferences_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String name()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.prefs.Preferences_.staticClass, "name", "()Ljava/lang/String;", ref global::java.util.prefs.Preferences_._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.util.prefs.Preferences parent()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.prefs.Preferences_.staticClass, "parent", "()Ljava/util/prefs/Preferences;", ref global::java.util.prefs.Preferences_._m1) as java.util.prefs.Preferences;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::java.lang.String get(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.prefs.Preferences_.staticClass, "get", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", ref global::java.util.prefs.Preferences_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override void put(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.prefs.Preferences_.staticClass, "put", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::java.util.prefs.Preferences_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.prefs.Preferences_.staticClass, "toString", "()Ljava/lang/String;", ref global::java.util.prefs.Preferences_._m4) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override bool getBoolean(java.lang.String arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.prefs.Preferences_.staticClass, "getBoolean", "(Ljava/lang/String;Z)Z", ref global::java.util.prefs.Preferences_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override void putBoolean(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.prefs.Preferences_.staticClass, "putBoolean", "(Ljava/lang/String;Z)V", ref global::java.util.prefs.Preferences_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override int getInt(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.prefs.Preferences_.staticClass, "getInt", "(Ljava/lang/String;I)I", ref global::java.util.prefs.Preferences_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override void putInt(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.prefs.Preferences_.staticClass, "putInt", "(Ljava/lang/String;I)V", ref global::java.util.prefs.Preferences_._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override long getLong(java.lang.String arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.prefs.Preferences_.staticClass, "getLong", "(Ljava/lang/String;J)J", ref global::java.util.prefs.Preferences_._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public override void putLong(java.lang.String arg0, long arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.prefs.Preferences_.staticClass, "putLong", "(Ljava/lang/String;J)V", ref global::java.util.prefs.Preferences_._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public override float getFloat(java.lang.String arg0, float arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::java.util.prefs.Preferences_.staticClass, "getFloat", "(Ljava/lang/String;F)F", ref global::java.util.prefs.Preferences_._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public override void putFloat(java.lang.String arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.prefs.Preferences_.staticClass, "putFloat", "(Ljava/lang/String;F)V", ref global::java.util.prefs.Preferences_._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public override double getDouble(java.lang.String arg0, double arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::java.util.prefs.Preferences_.staticClass, "getDouble", "(Ljava/lang/String;D)D", ref global::java.util.prefs.Preferences_._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public override void putDouble(java.lang.String arg0, double arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.prefs.Preferences_.staticClass, "putDouble", "(Ljava/lang/String;D)V", ref global::java.util.prefs.Preferences_._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public override void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.prefs.Preferences_.staticClass, "clear", "()V", ref global::java.util.prefs.Preferences_._m15);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public override void remove(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.prefs.Preferences_.staticClass, "remove", "(Ljava/lang/String;)V", ref global::java.util.prefs.Preferences_._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public override global::java.lang.String[] keys()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::java.util.prefs.Preferences_.staticClass, "keys", "()[Ljava/lang/String;", ref global::java.util.prefs.Preferences_._m17) as java.lang.String[];
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public override void flush()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.prefs.Preferences_.staticClass, "flush", "()V", ref global::java.util.prefs.Preferences_._m18);
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public override void sync()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.prefs.Preferences_.staticClass, "sync", "()V", ref global::java.util.prefs.Preferences_._m19);
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public override void putByteArray(java.lang.String arg0, byte[] arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.prefs.Preferences_.staticClass, "putByteArray", "(Ljava/lang/String;[B)V", ref global::java.util.prefs.Preferences_._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public override byte[] getByteArray(java.lang.String arg0, byte[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.util.prefs.Preferences_.staticClass, "getByteArray", "(Ljava/lang/String;[B)[B", ref global::java.util.prefs.Preferences_._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public override global::java.util.prefs.Preferences node(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.prefs.Preferences_.staticClass, "node", "(Ljava/lang/String;)Ljava/util/prefs/Preferences;", ref global::java.util.prefs.Preferences_._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.prefs.Preferences;
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public override global::java.lang.String absolutePath()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.prefs.Preferences_.staticClass, "absolutePath", "()Ljava/lang/String;", ref global::java.util.prefs.Preferences_._m23) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public override global::java.lang.String[] childrenNames()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::java.util.prefs.Preferences_.staticClass, "childrenNames", "()[Ljava/lang/String;", ref global::java.util.prefs.Preferences_._m24) as java.lang.String[];
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public override bool nodeExists(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.prefs.Preferences_.staticClass, "nodeExists", "(Ljava/lang/String;)Z", ref global::java.util.prefs.Preferences_._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public override void removeNode()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.prefs.Preferences_.staticClass, "removeNode", "()V", ref global::java.util.prefs.Preferences_._m26);
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public override bool isUserNode()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.prefs.Preferences_.staticClass, "isUserNode", "()Z", ref global::java.util.prefs.Preferences_._m27);
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public override void addPreferenceChangeListener(java.util.prefs.PreferenceChangeListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.prefs.Preferences_.staticClass, "addPreferenceChangeListener", "(Ljava/util/prefs/PreferenceChangeListener;)V", ref global::java.util.prefs.Preferences_._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public override void removePreferenceChangeListener(java.util.prefs.PreferenceChangeListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.prefs.Preferences_.staticClass, "removePreferenceChangeListener", "(Ljava/util/prefs/PreferenceChangeListener;)V", ref global::java.util.prefs.Preferences_._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public override void addNodeChangeListener(java.util.prefs.NodeChangeListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.prefs.Preferences_.staticClass, "addNodeChangeListener", "(Ljava/util/prefs/NodeChangeListener;)V", ref global::java.util.prefs.Preferences_._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public override void removeNodeChangeListener(java.util.prefs.NodeChangeListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.prefs.Preferences_.staticClass, "removeNodeChangeListener", "(Ljava/util/prefs/NodeChangeListener;)V", ref global::java.util.prefs.Preferences_._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public override void exportNode(java.io.OutputStream arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.prefs.Preferences_.staticClass, "exportNode", "(Ljava/io/OutputStream;)V", ref global::java.util.prefs.Preferences_._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public override void exportSubtree(java.io.OutputStream arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.prefs.Preferences_.staticClass, "exportSubtree", "(Ljava/io/OutputStream;)V", ref global::java.util.prefs.Preferences_._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static Preferences_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.prefs.Preferences_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/prefs/Preferences"));
		}
	}
}
