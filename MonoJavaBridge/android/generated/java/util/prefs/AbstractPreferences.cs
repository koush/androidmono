namespace java.util.prefs
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.prefs.AbstractPreferences_))]
	public abstract partial class AbstractPreferences : java.util.prefs.Preferences
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AbstractPreferences(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String name()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.prefs.AbstractPreferences.staticClass, "name", "()Ljava/lang/String;", ref global::java.util.prefs.AbstractPreferences._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.util.prefs.Preferences parent()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.prefs.AbstractPreferences.staticClass, "parent", "()Ljava/util/prefs/Preferences;", ref global::java.util.prefs.AbstractPreferences._m1) as java.util.prefs.Preferences;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::java.lang.String get(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.prefs.AbstractPreferences.staticClass, "get", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", ref global::java.util.prefs.AbstractPreferences._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override void put(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.prefs.AbstractPreferences.staticClass, "put", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::java.util.prefs.AbstractPreferences._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.prefs.AbstractPreferences.staticClass, "toString", "()Ljava/lang/String;", ref global::java.util.prefs.AbstractPreferences._m4) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override bool getBoolean(java.lang.String arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.prefs.AbstractPreferences.staticClass, "getBoolean", "(Ljava/lang/String;Z)Z", ref global::java.util.prefs.AbstractPreferences._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override void putBoolean(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.prefs.AbstractPreferences.staticClass, "putBoolean", "(Ljava/lang/String;Z)V", ref global::java.util.prefs.AbstractPreferences._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override int getInt(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.prefs.AbstractPreferences.staticClass, "getInt", "(Ljava/lang/String;I)I", ref global::java.util.prefs.AbstractPreferences._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override void putInt(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.prefs.AbstractPreferences.staticClass, "putInt", "(Ljava/lang/String;I)V", ref global::java.util.prefs.AbstractPreferences._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override long getLong(java.lang.String arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.prefs.AbstractPreferences.staticClass, "getLong", "(Ljava/lang/String;J)J", ref global::java.util.prefs.AbstractPreferences._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public override void putLong(java.lang.String arg0, long arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.prefs.AbstractPreferences.staticClass, "putLong", "(Ljava/lang/String;J)V", ref global::java.util.prefs.AbstractPreferences._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public override float getFloat(java.lang.String arg0, float arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::java.util.prefs.AbstractPreferences.staticClass, "getFloat", "(Ljava/lang/String;F)F", ref global::java.util.prefs.AbstractPreferences._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public override void putFloat(java.lang.String arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.prefs.AbstractPreferences.staticClass, "putFloat", "(Ljava/lang/String;F)V", ref global::java.util.prefs.AbstractPreferences._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public override double getDouble(java.lang.String arg0, double arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::java.util.prefs.AbstractPreferences.staticClass, "getDouble", "(Ljava/lang/String;D)D", ref global::java.util.prefs.AbstractPreferences._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public override void putDouble(java.lang.String arg0, double arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.prefs.AbstractPreferences.staticClass, "putDouble", "(Ljava/lang/String;D)V", ref global::java.util.prefs.AbstractPreferences._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public override void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.prefs.AbstractPreferences.staticClass, "clear", "()V", ref global::java.util.prefs.AbstractPreferences._m15);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public override void remove(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.prefs.AbstractPreferences.staticClass, "remove", "(Ljava/lang/String;)V", ref global::java.util.prefs.AbstractPreferences._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public override global::java.lang.String[] keys()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::java.util.prefs.AbstractPreferences.staticClass, "keys", "()[Ljava/lang/String;", ref global::java.util.prefs.AbstractPreferences._m17) as java.lang.String[];
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public override void flush()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.prefs.AbstractPreferences.staticClass, "flush", "()V", ref global::java.util.prefs.AbstractPreferences._m18);
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public override void sync()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.prefs.AbstractPreferences.staticClass, "sync", "()V", ref global::java.util.prefs.AbstractPreferences._m19);
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public override void putByteArray(java.lang.String arg0, byte[] arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.prefs.AbstractPreferences.staticClass, "putByteArray", "(Ljava/lang/String;[B)V", ref global::java.util.prefs.AbstractPreferences._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public override byte[] getByteArray(java.lang.String arg0, byte[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.util.prefs.AbstractPreferences.staticClass, "getByteArray", "(Ljava/lang/String;[B)[B", ref global::java.util.prefs.AbstractPreferences._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m22;
		protected virtual global::java.util.prefs.AbstractPreferences getChild(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.prefs.AbstractPreferences.staticClass, "getChild", "(Ljava/lang/String;)Ljava/util/prefs/AbstractPreferences;", ref global::java.util.prefs.AbstractPreferences._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.prefs.AbstractPreferences;
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public override global::java.util.prefs.Preferences node(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.prefs.AbstractPreferences.staticClass, "node", "(Ljava/lang/String;)Ljava/util/prefs/Preferences;", ref global::java.util.prefs.AbstractPreferences._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.prefs.Preferences;
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public override global::java.lang.String absolutePath()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.prefs.AbstractPreferences.staticClass, "absolutePath", "()Ljava/lang/String;", ref global::java.util.prefs.AbstractPreferences._m24) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public override global::java.lang.String[] childrenNames()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::java.util.prefs.AbstractPreferences.staticClass, "childrenNames", "()[Ljava/lang/String;", ref global::java.util.prefs.AbstractPreferences._m25) as java.lang.String[];
		}
		private static global::MonoJavaBridge.MethodId _m26;
		protected virtual global::java.util.prefs.AbstractPreferences[] cachedChildren()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.util.prefs.AbstractPreferences>(this, global::java.util.prefs.AbstractPreferences.staticClass, "cachedChildren", "()[Ljava/util/prefs/AbstractPreferences;", ref global::java.util.prefs.AbstractPreferences._m26) as java.util.prefs.AbstractPreferences[];
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public override bool nodeExists(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.prefs.AbstractPreferences.staticClass, "nodeExists", "(Ljava/lang/String;)Z", ref global::java.util.prefs.AbstractPreferences._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public override void removeNode()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.prefs.AbstractPreferences.staticClass, "removeNode", "()V", ref global::java.util.prefs.AbstractPreferences._m28);
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public override bool isUserNode()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.prefs.AbstractPreferences.staticClass, "isUserNode", "()Z", ref global::java.util.prefs.AbstractPreferences._m29);
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public override void addPreferenceChangeListener(java.util.prefs.PreferenceChangeListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.prefs.AbstractPreferences.staticClass, "addPreferenceChangeListener", "(Ljava/util/prefs/PreferenceChangeListener;)V", ref global::java.util.prefs.AbstractPreferences._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public override void removePreferenceChangeListener(java.util.prefs.PreferenceChangeListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.prefs.AbstractPreferences.staticClass, "removePreferenceChangeListener", "(Ljava/util/prefs/PreferenceChangeListener;)V", ref global::java.util.prefs.AbstractPreferences._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public override void addNodeChangeListener(java.util.prefs.NodeChangeListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.prefs.AbstractPreferences.staticClass, "addNodeChangeListener", "(Ljava/util/prefs/NodeChangeListener;)V", ref global::java.util.prefs.AbstractPreferences._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public override void removeNodeChangeListener(java.util.prefs.NodeChangeListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.prefs.AbstractPreferences.staticClass, "removeNodeChangeListener", "(Ljava/util/prefs/NodeChangeListener;)V", ref global::java.util.prefs.AbstractPreferences._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m34;
		protected abstract void putSpi(java.lang.String arg0, java.lang.String arg1);
		private static global::MonoJavaBridge.MethodId _m35;
		protected abstract global::java.lang.String getSpi(java.lang.String arg0);
		private static global::MonoJavaBridge.MethodId _m36;
		protected abstract void removeSpi(java.lang.String arg0);
		private static global::MonoJavaBridge.MethodId _m37;
		protected abstract void removeNodeSpi();
		private static global::MonoJavaBridge.MethodId _m38;
		protected abstract global::java.lang.String[] keysSpi();
		private static global::MonoJavaBridge.MethodId _m39;
		protected abstract global::java.lang.String[] childrenNamesSpi();
		private static global::MonoJavaBridge.MethodId _m40;
		protected abstract global::java.util.prefs.AbstractPreferences childSpi(java.lang.String arg0);
		private static global::MonoJavaBridge.MethodId _m41;
		protected abstract void syncSpi();
		private static global::MonoJavaBridge.MethodId _m42;
		protected abstract void flushSpi();
		private static global::MonoJavaBridge.MethodId _m43;
		protected virtual bool isRemoved()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.prefs.AbstractPreferences.staticClass, "isRemoved", "()Z", ref global::java.util.prefs.AbstractPreferences._m43);
		}
		private static global::MonoJavaBridge.MethodId _m44;
		public override void exportNode(java.io.OutputStream arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.prefs.AbstractPreferences.staticClass, "exportNode", "(Ljava/io/OutputStream;)V", ref global::java.util.prefs.AbstractPreferences._m44, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m45;
		public override void exportSubtree(java.io.OutputStream arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.prefs.AbstractPreferences.staticClass, "exportSubtree", "(Ljava/io/OutputStream;)V", ref global::java.util.prefs.AbstractPreferences._m45, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m46;
		protected AbstractPreferences(java.util.prefs.AbstractPreferences arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.prefs.AbstractPreferences._m46.native == global::System.IntPtr.Zero)
				global::java.util.prefs.AbstractPreferences._m46 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "<init>", "(Ljava/util/prefs/AbstractPreferences;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._m46, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static AbstractPreferences()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.prefs.AbstractPreferences.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/prefs/AbstractPreferences"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.prefs.AbstractPreferences))]
	internal sealed partial class AbstractPreferences_ : java.util.prefs.AbstractPreferences
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AbstractPreferences_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void putSpi(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.prefs.AbstractPreferences_.staticClass, "putSpi", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::java.util.prefs.AbstractPreferences_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected override global::java.lang.String getSpi(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.prefs.AbstractPreferences_.staticClass, "getSpi", "(Ljava/lang/String;)Ljava/lang/String;", ref global::java.util.prefs.AbstractPreferences_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected override void removeSpi(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.prefs.AbstractPreferences_.staticClass, "removeSpi", "(Ljava/lang/String;)V", ref global::java.util.prefs.AbstractPreferences_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		protected override void removeNodeSpi()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.prefs.AbstractPreferences_.staticClass, "removeNodeSpi", "()V", ref global::java.util.prefs.AbstractPreferences_._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		protected override global::java.lang.String[] keysSpi()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::java.util.prefs.AbstractPreferences_.staticClass, "keysSpi", "()[Ljava/lang/String;", ref global::java.util.prefs.AbstractPreferences_._m4) as java.lang.String[];
		}
		private static global::MonoJavaBridge.MethodId _m5;
		protected override global::java.lang.String[] childrenNamesSpi()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::java.util.prefs.AbstractPreferences_.staticClass, "childrenNamesSpi", "()[Ljava/lang/String;", ref global::java.util.prefs.AbstractPreferences_._m5) as java.lang.String[];
		}
		private static global::MonoJavaBridge.MethodId _m6;
		protected override global::java.util.prefs.AbstractPreferences childSpi(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.prefs.AbstractPreferences_.staticClass, "childSpi", "(Ljava/lang/String;)Ljava/util/prefs/AbstractPreferences;", ref global::java.util.prefs.AbstractPreferences_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.prefs.AbstractPreferences;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		protected override void syncSpi()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.prefs.AbstractPreferences_.staticClass, "syncSpi", "()V", ref global::java.util.prefs.AbstractPreferences_._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		protected override void flushSpi()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.prefs.AbstractPreferences_.staticClass, "flushSpi", "()V", ref global::java.util.prefs.AbstractPreferences_._m8);
		}
		static AbstractPreferences_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.prefs.AbstractPreferences_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/prefs/AbstractPreferences"));
		}
	}
}
