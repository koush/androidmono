namespace java.util.prefs
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.prefs.AbstractPreferences_))]
	public abstract partial class AbstractPreferences : java.util.prefs.Preferences
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractPreferences()
		{
			InitJNI();
		}
		protected AbstractPreferences(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _name27997;
		public override global::java.lang.String name() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._name27997)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._name27997)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _parent27998;
		public override global::java.util.prefs.Preferences parent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._parent27998)) as java.util.prefs.Preferences;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._parent27998)) as java.util.prefs.Preferences;
		}
		internal static global::MonoJavaBridge.MethodId _get27999;
		public override global::java.lang.String get(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._get27999, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._get27999, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _put28000;
		public override void put(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._put28000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._put28000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _toString28001;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._toString28001)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._toString28001)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getBoolean28002;
		public override bool getBoolean(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._getBoolean28002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._getBoolean28002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putBoolean28003;
		public override void putBoolean(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._putBoolean28003, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._putBoolean28003, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getInt28004;
		public override int getInt(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._getInt28004, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._getInt28004, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putInt28005;
		public override void putInt(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._putInt28005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._putInt28005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getLong28006;
		public override long getLong(java.lang.String arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._getLong28006, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._getLong28006, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putLong28007;
		public override void putLong(java.lang.String arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._putLong28007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._putLong28007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFloat28008;
		public override float getFloat(java.lang.String arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._getFloat28008, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._getFloat28008, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putFloat28009;
		public override void putFloat(java.lang.String arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._putFloat28009, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._putFloat28009, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getDouble28010;
		public override double getDouble(java.lang.String arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._getDouble28010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._getDouble28010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putDouble28011;
		public override void putDouble(java.lang.String arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._putDouble28011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._putDouble28011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _clear28012;
		public override void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._clear28012);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._clear28012);
		}
		internal static global::MonoJavaBridge.MethodId _remove28013;
		public override void remove(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._remove28013, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._remove28013, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _keys28014;
		public override global::java.lang.String[] keys() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._keys28014)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._keys28014)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _flush28015;
		public override void flush() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._flush28015);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._flush28015);
		}
		internal static global::MonoJavaBridge.MethodId _sync28016;
		public override void sync() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._sync28016);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._sync28016);
		}
		internal static global::MonoJavaBridge.MethodId _putByteArray28017;
		public override void putByteArray(java.lang.String arg0, byte[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._putByteArray28017, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._putByteArray28017, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getByteArray28018;
		public override byte[] getByteArray(java.lang.String arg0, byte[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._getByteArray28018, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._getByteArray28018, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getChild28019;
		protected virtual global::java.util.prefs.AbstractPreferences getChild(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._getChild28019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.prefs.AbstractPreferences;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._getChild28019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.prefs.AbstractPreferences;
		}
		internal static global::MonoJavaBridge.MethodId _node28020;
		public override global::java.util.prefs.Preferences node(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._node28020, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.prefs.Preferences;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._node28020, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.prefs.Preferences;
		}
		internal static global::MonoJavaBridge.MethodId _absolutePath28021;
		public override global::java.lang.String absolutePath() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._absolutePath28021)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._absolutePath28021)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _childrenNames28022;
		public override global::java.lang.String[] childrenNames() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._childrenNames28022)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._childrenNames28022)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _cachedChildren28023;
		protected virtual global::java.util.prefs.AbstractPreferences[] cachedChildren() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.util.prefs.AbstractPreferences>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._cachedChildren28023)) as java.util.prefs.AbstractPreferences[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.util.prefs.AbstractPreferences>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._cachedChildren28023)) as java.util.prefs.AbstractPreferences[];
		}
		internal static global::MonoJavaBridge.MethodId _nodeExists28024;
		public override bool nodeExists(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._nodeExists28024, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._nodeExists28024, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeNode28025;
		public override void removeNode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._removeNode28025);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._removeNode28025);
		}
		internal static global::MonoJavaBridge.MethodId _isUserNode28026;
		public override bool isUserNode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._isUserNode28026);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._isUserNode28026);
		}
		internal static global::MonoJavaBridge.MethodId _addPreferenceChangeListener28027;
		public override void addPreferenceChangeListener(java.util.prefs.PreferenceChangeListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._addPreferenceChangeListener28027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._addPreferenceChangeListener28027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removePreferenceChangeListener28028;
		public override void removePreferenceChangeListener(java.util.prefs.PreferenceChangeListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._removePreferenceChangeListener28028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._removePreferenceChangeListener28028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addNodeChangeListener28029;
		public override void addNodeChangeListener(java.util.prefs.NodeChangeListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._addNodeChangeListener28029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._addNodeChangeListener28029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeNodeChangeListener28030;
		public override void removeNodeChangeListener(java.util.prefs.NodeChangeListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._removeNodeChangeListener28030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._removeNodeChangeListener28030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _putSpi28031;
		protected abstract void putSpi(java.lang.String arg0, java.lang.String arg1);
		internal static global::MonoJavaBridge.MethodId _getSpi28032;
		protected abstract global::java.lang.String getSpi(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _removeSpi28033;
		protected abstract void removeSpi(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _removeNodeSpi28034;
		protected abstract void removeNodeSpi();
		internal static global::MonoJavaBridge.MethodId _keysSpi28035;
		protected abstract global::java.lang.String[] keysSpi();
		internal static global::MonoJavaBridge.MethodId _childrenNamesSpi28036;
		protected abstract global::java.lang.String[] childrenNamesSpi();
		internal static global::MonoJavaBridge.MethodId _childSpi28037;
		protected abstract global::java.util.prefs.AbstractPreferences childSpi(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _syncSpi28038;
		protected abstract void syncSpi();
		internal static global::MonoJavaBridge.MethodId _flushSpi28039;
		protected abstract void flushSpi();
		internal static global::MonoJavaBridge.MethodId _isRemoved28040;
		protected virtual bool isRemoved() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._isRemoved28040);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._isRemoved28040);
		}
		internal static global::MonoJavaBridge.MethodId _exportNode28041;
		public override void exportNode(java.io.OutputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._exportNode28041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._exportNode28041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _exportSubtree28042;
		public override void exportSubtree(java.io.OutputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._exportSubtree28042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._exportSubtree28042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _AbstractPreferences28043;
		protected AbstractPreferences(java.util.prefs.AbstractPreferences arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._AbstractPreferences28043, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.prefs.AbstractPreferences.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/prefs/AbstractPreferences"));
			global::java.util.prefs.AbstractPreferences._name27997 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "name", "()Ljava/lang/String;");
			global::java.util.prefs.AbstractPreferences._parent27998 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "parent", "()Ljava/util/prefs/Preferences;");
			global::java.util.prefs.AbstractPreferences._get27999 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "get", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::java.util.prefs.AbstractPreferences._put28000 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "put", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.util.prefs.AbstractPreferences._toString28001 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.prefs.AbstractPreferences._getBoolean28002 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "getBoolean", "(Ljava/lang/String;Z)Z");
			global::java.util.prefs.AbstractPreferences._putBoolean28003 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "putBoolean", "(Ljava/lang/String;Z)V");
			global::java.util.prefs.AbstractPreferences._getInt28004 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "getInt", "(Ljava/lang/String;I)I");
			global::java.util.prefs.AbstractPreferences._putInt28005 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "putInt", "(Ljava/lang/String;I)V");
			global::java.util.prefs.AbstractPreferences._getLong28006 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "getLong", "(Ljava/lang/String;J)J");
			global::java.util.prefs.AbstractPreferences._putLong28007 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "putLong", "(Ljava/lang/String;J)V");
			global::java.util.prefs.AbstractPreferences._getFloat28008 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "getFloat", "(Ljava/lang/String;F)F");
			global::java.util.prefs.AbstractPreferences._putFloat28009 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "putFloat", "(Ljava/lang/String;F)V");
			global::java.util.prefs.AbstractPreferences._getDouble28010 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "getDouble", "(Ljava/lang/String;D)D");
			global::java.util.prefs.AbstractPreferences._putDouble28011 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "putDouble", "(Ljava/lang/String;D)V");
			global::java.util.prefs.AbstractPreferences._clear28012 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "clear", "()V");
			global::java.util.prefs.AbstractPreferences._remove28013 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "remove", "(Ljava/lang/String;)V");
			global::java.util.prefs.AbstractPreferences._keys28014 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "keys", "()[Ljava/lang/String;");
			global::java.util.prefs.AbstractPreferences._flush28015 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "flush", "()V");
			global::java.util.prefs.AbstractPreferences._sync28016 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "sync", "()V");
			global::java.util.prefs.AbstractPreferences._putByteArray28017 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "putByteArray", "(Ljava/lang/String;[B)V");
			global::java.util.prefs.AbstractPreferences._getByteArray28018 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "getByteArray", "(Ljava/lang/String;[B)[B");
			global::java.util.prefs.AbstractPreferences._getChild28019 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "getChild", "(Ljava/lang/String;)Ljava/util/prefs/AbstractPreferences;");
			global::java.util.prefs.AbstractPreferences._node28020 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "node", "(Ljava/lang/String;)Ljava/util/prefs/Preferences;");
			global::java.util.prefs.AbstractPreferences._absolutePath28021 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "absolutePath", "()Ljava/lang/String;");
			global::java.util.prefs.AbstractPreferences._childrenNames28022 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "childrenNames", "()[Ljava/lang/String;");
			global::java.util.prefs.AbstractPreferences._cachedChildren28023 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "cachedChildren", "()[Ljava/util/prefs/AbstractPreferences;");
			global::java.util.prefs.AbstractPreferences._nodeExists28024 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "nodeExists", "(Ljava/lang/String;)Z");
			global::java.util.prefs.AbstractPreferences._removeNode28025 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "removeNode", "()V");
			global::java.util.prefs.AbstractPreferences._isUserNode28026 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "isUserNode", "()Z");
			global::java.util.prefs.AbstractPreferences._addPreferenceChangeListener28027 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "addPreferenceChangeListener", "(Ljava/util/prefs/PreferenceChangeListener;)V");
			global::java.util.prefs.AbstractPreferences._removePreferenceChangeListener28028 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "removePreferenceChangeListener", "(Ljava/util/prefs/PreferenceChangeListener;)V");
			global::java.util.prefs.AbstractPreferences._addNodeChangeListener28029 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "addNodeChangeListener", "(Ljava/util/prefs/NodeChangeListener;)V");
			global::java.util.prefs.AbstractPreferences._removeNodeChangeListener28030 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "removeNodeChangeListener", "(Ljava/util/prefs/NodeChangeListener;)V");
			global::java.util.prefs.AbstractPreferences._putSpi28031 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "putSpi", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.util.prefs.AbstractPreferences._getSpi28032 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "getSpi", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.util.prefs.AbstractPreferences._removeSpi28033 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "removeSpi", "(Ljava/lang/String;)V");
			global::java.util.prefs.AbstractPreferences._removeNodeSpi28034 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "removeNodeSpi", "()V");
			global::java.util.prefs.AbstractPreferences._keysSpi28035 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "keysSpi", "()[Ljava/lang/String;");
			global::java.util.prefs.AbstractPreferences._childrenNamesSpi28036 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "childrenNamesSpi", "()[Ljava/lang/String;");
			global::java.util.prefs.AbstractPreferences._childSpi28037 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "childSpi", "(Ljava/lang/String;)Ljava/util/prefs/AbstractPreferences;");
			global::java.util.prefs.AbstractPreferences._syncSpi28038 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "syncSpi", "()V");
			global::java.util.prefs.AbstractPreferences._flushSpi28039 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "flushSpi", "()V");
			global::java.util.prefs.AbstractPreferences._isRemoved28040 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "isRemoved", "()Z");
			global::java.util.prefs.AbstractPreferences._exportNode28041 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "exportNode", "(Ljava/io/OutputStream;)V");
			global::java.util.prefs.AbstractPreferences._exportSubtree28042 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "exportSubtree", "(Ljava/io/OutputStream;)V");
			global::java.util.prefs.AbstractPreferences._AbstractPreferences28043 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "<init>", "(Ljava/util/prefs/AbstractPreferences;Ljava/lang/String;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.prefs.AbstractPreferences))]
	public sealed partial class AbstractPreferences_ : java.util.prefs.AbstractPreferences
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractPreferences_()
		{
			InitJNI();
		}
		internal AbstractPreferences_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _putSpi28044;
		protected override void putSpi(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences_._putSpi28044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences_.staticClass, global::java.util.prefs.AbstractPreferences_._putSpi28044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getSpi28045;
		protected override global::java.lang.String getSpi(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences_._getSpi28045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences_.staticClass, global::java.util.prefs.AbstractPreferences_._getSpi28045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _removeSpi28046;
		protected override void removeSpi(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences_._removeSpi28046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences_.staticClass, global::java.util.prefs.AbstractPreferences_._removeSpi28046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeNodeSpi28047;
		protected override void removeNodeSpi() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences_._removeNodeSpi28047);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences_.staticClass, global::java.util.prefs.AbstractPreferences_._removeNodeSpi28047);
		}
		internal static global::MonoJavaBridge.MethodId _keysSpi28048;
		protected override global::java.lang.String[] keysSpi() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences_._keysSpi28048)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences_.staticClass, global::java.util.prefs.AbstractPreferences_._keysSpi28048)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _childrenNamesSpi28049;
		protected override global::java.lang.String[] childrenNamesSpi() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences_._childrenNamesSpi28049)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences_.staticClass, global::java.util.prefs.AbstractPreferences_._childrenNamesSpi28049)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _childSpi28050;
		protected override global::java.util.prefs.AbstractPreferences childSpi(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences_._childSpi28050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.prefs.AbstractPreferences;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences_.staticClass, global::java.util.prefs.AbstractPreferences_._childSpi28050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.prefs.AbstractPreferences;
		}
		internal static global::MonoJavaBridge.MethodId _syncSpi28051;
		protected override void syncSpi() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences_._syncSpi28051);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences_.staticClass, global::java.util.prefs.AbstractPreferences_._syncSpi28051);
		}
		internal static global::MonoJavaBridge.MethodId _flushSpi28052;
		protected override void flushSpi() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences_._flushSpi28052);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences_.staticClass, global::java.util.prefs.AbstractPreferences_._flushSpi28052);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.prefs.AbstractPreferences_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/prefs/AbstractPreferences"));
			global::java.util.prefs.AbstractPreferences_._putSpi28044 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences_.staticClass, "putSpi", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.util.prefs.AbstractPreferences_._getSpi28045 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences_.staticClass, "getSpi", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.util.prefs.AbstractPreferences_._removeSpi28046 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences_.staticClass, "removeSpi", "(Ljava/lang/String;)V");
			global::java.util.prefs.AbstractPreferences_._removeNodeSpi28047 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences_.staticClass, "removeNodeSpi", "()V");
			global::java.util.prefs.AbstractPreferences_._keysSpi28048 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences_.staticClass, "keysSpi", "()[Ljava/lang/String;");
			global::java.util.prefs.AbstractPreferences_._childrenNamesSpi28049 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences_.staticClass, "childrenNamesSpi", "()[Ljava/lang/String;");
			global::java.util.prefs.AbstractPreferences_._childSpi28050 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences_.staticClass, "childSpi", "(Ljava/lang/String;)Ljava/util/prefs/AbstractPreferences;");
			global::java.util.prefs.AbstractPreferences_._syncSpi28051 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences_.staticClass, "syncSpi", "()V");
			global::java.util.prefs.AbstractPreferences_._flushSpi28052 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences_.staticClass, "flushSpi", "()V");
		}
	}
}
