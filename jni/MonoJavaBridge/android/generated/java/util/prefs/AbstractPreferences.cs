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
		internal static global::MonoJavaBridge.MethodId _name22134;
		public override global::java.lang.String name() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._name22134)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._name22134)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _parent22135;
		public override global::java.util.prefs.Preferences parent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._parent22135)) as java.util.prefs.Preferences;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._parent22135)) as java.util.prefs.Preferences;
		}
		internal static global::MonoJavaBridge.MethodId _get22136;
		public override global::java.lang.String get(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._get22136, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._get22136, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _put22137;
		public override void put(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._put22137, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._put22137, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _toString22138;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._toString22138)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._toString22138)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getBoolean22139;
		public override bool getBoolean(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._getBoolean22139, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._getBoolean22139, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putBoolean22140;
		public override void putBoolean(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._putBoolean22140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._putBoolean22140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getInt22141;
		public override int getInt(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._getInt22141, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._getInt22141, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putInt22142;
		public override void putInt(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._putInt22142, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._putInt22142, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getLong22143;
		public override long getLong(java.lang.String arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._getLong22143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._getLong22143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putLong22144;
		public override void putLong(java.lang.String arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._putLong22144, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._putLong22144, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFloat22145;
		public override float getFloat(java.lang.String arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._getFloat22145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._getFloat22145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putFloat22146;
		public override void putFloat(java.lang.String arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._putFloat22146, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._putFloat22146, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getDouble22147;
		public override double getDouble(java.lang.String arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._getDouble22147, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._getDouble22147, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putDouble22148;
		public override void putDouble(java.lang.String arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._putDouble22148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._putDouble22148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _clear22149;
		public override void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._clear22149);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._clear22149);
		}
		internal static global::MonoJavaBridge.MethodId _remove22150;
		public override void remove(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._remove22150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._remove22150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _keys22151;
		public override global::java.lang.String[] keys() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._keys22151)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._keys22151)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _flush22152;
		public override void flush() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._flush22152);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._flush22152);
		}
		internal static global::MonoJavaBridge.MethodId _sync22153;
		public override void sync() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._sync22153);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._sync22153);
		}
		internal static global::MonoJavaBridge.MethodId _putByteArray22154;
		public override void putByteArray(java.lang.String arg0, byte[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._putByteArray22154, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._putByteArray22154, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getByteArray22155;
		public override byte[] getByteArray(java.lang.String arg0, byte[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._getByteArray22155, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._getByteArray22155, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getChild22156;
		protected virtual global::java.util.prefs.AbstractPreferences getChild(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._getChild22156, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.prefs.AbstractPreferences;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._getChild22156, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.prefs.AbstractPreferences;
		}
		internal static global::MonoJavaBridge.MethodId _node22157;
		public override global::java.util.prefs.Preferences node(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._node22157, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.prefs.Preferences;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._node22157, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.prefs.Preferences;
		}
		internal static global::MonoJavaBridge.MethodId _absolutePath22158;
		public override global::java.lang.String absolutePath() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._absolutePath22158)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._absolutePath22158)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _childrenNames22159;
		public override global::java.lang.String[] childrenNames() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._childrenNames22159)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._childrenNames22159)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _cachedChildren22160;
		protected virtual global::java.util.prefs.AbstractPreferences[] cachedChildren() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.util.prefs.AbstractPreferences>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._cachedChildren22160)) as java.util.prefs.AbstractPreferences[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.util.prefs.AbstractPreferences>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._cachedChildren22160)) as java.util.prefs.AbstractPreferences[];
		}
		internal static global::MonoJavaBridge.MethodId _nodeExists22161;
		public override bool nodeExists(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._nodeExists22161, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._nodeExists22161, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeNode22162;
		public override void removeNode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._removeNode22162);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._removeNode22162);
		}
		internal static global::MonoJavaBridge.MethodId _isUserNode22163;
		public override bool isUserNode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._isUserNode22163);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._isUserNode22163);
		}
		internal static global::MonoJavaBridge.MethodId _addPreferenceChangeListener22164;
		public override void addPreferenceChangeListener(java.util.prefs.PreferenceChangeListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._addPreferenceChangeListener22164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._addPreferenceChangeListener22164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removePreferenceChangeListener22165;
		public override void removePreferenceChangeListener(java.util.prefs.PreferenceChangeListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._removePreferenceChangeListener22165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._removePreferenceChangeListener22165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addNodeChangeListener22166;
		public override void addNodeChangeListener(java.util.prefs.NodeChangeListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._addNodeChangeListener22166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._addNodeChangeListener22166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeNodeChangeListener22167;
		public override void removeNodeChangeListener(java.util.prefs.NodeChangeListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._removeNodeChangeListener22167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._removeNodeChangeListener22167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _putSpi22168;
		protected abstract void putSpi(java.lang.String arg0, java.lang.String arg1);
		internal static global::MonoJavaBridge.MethodId _getSpi22169;
		protected abstract global::java.lang.String getSpi(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _removeSpi22170;
		protected abstract void removeSpi(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _removeNodeSpi22171;
		protected abstract void removeNodeSpi();
		internal static global::MonoJavaBridge.MethodId _keysSpi22172;
		protected abstract global::java.lang.String[] keysSpi();
		internal static global::MonoJavaBridge.MethodId _childrenNamesSpi22173;
		protected abstract global::java.lang.String[] childrenNamesSpi();
		internal static global::MonoJavaBridge.MethodId _childSpi22174;
		protected abstract global::java.util.prefs.AbstractPreferences childSpi(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _syncSpi22175;
		protected abstract void syncSpi();
		internal static global::MonoJavaBridge.MethodId _flushSpi22176;
		protected abstract void flushSpi();
		internal static global::MonoJavaBridge.MethodId _isRemoved22177;
		protected virtual bool isRemoved() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._isRemoved22177);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._isRemoved22177);
		}
		internal static global::MonoJavaBridge.MethodId _exportNode22178;
		public override void exportNode(java.io.OutputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._exportNode22178, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._exportNode22178, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _exportSubtree22179;
		public override void exportSubtree(java.io.OutputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._exportSubtree22179, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._exportSubtree22179, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _AbstractPreferences22180;
		protected AbstractPreferences(java.util.prefs.AbstractPreferences arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._AbstractPreferences22180, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.prefs.AbstractPreferences.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/prefs/AbstractPreferences"));
			global::java.util.prefs.AbstractPreferences._name22134 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "name", "()Ljava/lang/String;");
			global::java.util.prefs.AbstractPreferences._parent22135 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "parent", "()Ljava/util/prefs/Preferences;");
			global::java.util.prefs.AbstractPreferences._get22136 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "get", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::java.util.prefs.AbstractPreferences._put22137 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "put", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.util.prefs.AbstractPreferences._toString22138 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.prefs.AbstractPreferences._getBoolean22139 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "getBoolean", "(Ljava/lang/String;Z)Z");
			global::java.util.prefs.AbstractPreferences._putBoolean22140 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "putBoolean", "(Ljava/lang/String;Z)V");
			global::java.util.prefs.AbstractPreferences._getInt22141 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "getInt", "(Ljava/lang/String;I)I");
			global::java.util.prefs.AbstractPreferences._putInt22142 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "putInt", "(Ljava/lang/String;I)V");
			global::java.util.prefs.AbstractPreferences._getLong22143 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "getLong", "(Ljava/lang/String;J)J");
			global::java.util.prefs.AbstractPreferences._putLong22144 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "putLong", "(Ljava/lang/String;J)V");
			global::java.util.prefs.AbstractPreferences._getFloat22145 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "getFloat", "(Ljava/lang/String;F)F");
			global::java.util.prefs.AbstractPreferences._putFloat22146 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "putFloat", "(Ljava/lang/String;F)V");
			global::java.util.prefs.AbstractPreferences._getDouble22147 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "getDouble", "(Ljava/lang/String;D)D");
			global::java.util.prefs.AbstractPreferences._putDouble22148 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "putDouble", "(Ljava/lang/String;D)V");
			global::java.util.prefs.AbstractPreferences._clear22149 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "clear", "()V");
			global::java.util.prefs.AbstractPreferences._remove22150 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "remove", "(Ljava/lang/String;)V");
			global::java.util.prefs.AbstractPreferences._keys22151 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "keys", "()[Ljava/lang/String;");
			global::java.util.prefs.AbstractPreferences._flush22152 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "flush", "()V");
			global::java.util.prefs.AbstractPreferences._sync22153 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "sync", "()V");
			global::java.util.prefs.AbstractPreferences._putByteArray22154 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "putByteArray", "(Ljava/lang/String;[B)V");
			global::java.util.prefs.AbstractPreferences._getByteArray22155 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "getByteArray", "(Ljava/lang/String;[B)[B");
			global::java.util.prefs.AbstractPreferences._getChild22156 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "getChild", "(Ljava/lang/String;)Ljava/util/prefs/AbstractPreferences;");
			global::java.util.prefs.AbstractPreferences._node22157 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "node", "(Ljava/lang/String;)Ljava/util/prefs/Preferences;");
			global::java.util.prefs.AbstractPreferences._absolutePath22158 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "absolutePath", "()Ljava/lang/String;");
			global::java.util.prefs.AbstractPreferences._childrenNames22159 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "childrenNames", "()[Ljava/lang/String;");
			global::java.util.prefs.AbstractPreferences._cachedChildren22160 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "cachedChildren", "()[Ljava/util/prefs/AbstractPreferences;");
			global::java.util.prefs.AbstractPreferences._nodeExists22161 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "nodeExists", "(Ljava/lang/String;)Z");
			global::java.util.prefs.AbstractPreferences._removeNode22162 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "removeNode", "()V");
			global::java.util.prefs.AbstractPreferences._isUserNode22163 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "isUserNode", "()Z");
			global::java.util.prefs.AbstractPreferences._addPreferenceChangeListener22164 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "addPreferenceChangeListener", "(Ljava/util/prefs/PreferenceChangeListener;)V");
			global::java.util.prefs.AbstractPreferences._removePreferenceChangeListener22165 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "removePreferenceChangeListener", "(Ljava/util/prefs/PreferenceChangeListener;)V");
			global::java.util.prefs.AbstractPreferences._addNodeChangeListener22166 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "addNodeChangeListener", "(Ljava/util/prefs/NodeChangeListener;)V");
			global::java.util.prefs.AbstractPreferences._removeNodeChangeListener22167 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "removeNodeChangeListener", "(Ljava/util/prefs/NodeChangeListener;)V");
			global::java.util.prefs.AbstractPreferences._putSpi22168 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "putSpi", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.util.prefs.AbstractPreferences._getSpi22169 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "getSpi", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.util.prefs.AbstractPreferences._removeSpi22170 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "removeSpi", "(Ljava/lang/String;)V");
			global::java.util.prefs.AbstractPreferences._removeNodeSpi22171 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "removeNodeSpi", "()V");
			global::java.util.prefs.AbstractPreferences._keysSpi22172 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "keysSpi", "()[Ljava/lang/String;");
			global::java.util.prefs.AbstractPreferences._childrenNamesSpi22173 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "childrenNamesSpi", "()[Ljava/lang/String;");
			global::java.util.prefs.AbstractPreferences._childSpi22174 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "childSpi", "(Ljava/lang/String;)Ljava/util/prefs/AbstractPreferences;");
			global::java.util.prefs.AbstractPreferences._syncSpi22175 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "syncSpi", "()V");
			global::java.util.prefs.AbstractPreferences._flushSpi22176 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "flushSpi", "()V");
			global::java.util.prefs.AbstractPreferences._isRemoved22177 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "isRemoved", "()Z");
			global::java.util.prefs.AbstractPreferences._exportNode22178 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "exportNode", "(Ljava/io/OutputStream;)V");
			global::java.util.prefs.AbstractPreferences._exportSubtree22179 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "exportSubtree", "(Ljava/io/OutputStream;)V");
			global::java.util.prefs.AbstractPreferences._AbstractPreferences22180 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "<init>", "(Ljava/util/prefs/AbstractPreferences;Ljava/lang/String;)V");
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
		internal static global::MonoJavaBridge.MethodId _putSpi22181;
		protected override void putSpi(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences_._putSpi22181, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences_.staticClass, global::java.util.prefs.AbstractPreferences_._putSpi22181, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getSpi22182;
		protected override global::java.lang.String getSpi(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences_._getSpi22182, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences_.staticClass, global::java.util.prefs.AbstractPreferences_._getSpi22182, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _removeSpi22183;
		protected override void removeSpi(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences_._removeSpi22183, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences_.staticClass, global::java.util.prefs.AbstractPreferences_._removeSpi22183, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeNodeSpi22184;
		protected override void removeNodeSpi() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences_._removeNodeSpi22184);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences_.staticClass, global::java.util.prefs.AbstractPreferences_._removeNodeSpi22184);
		}
		internal static global::MonoJavaBridge.MethodId _keysSpi22185;
		protected override global::java.lang.String[] keysSpi() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences_._keysSpi22185)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences_.staticClass, global::java.util.prefs.AbstractPreferences_._keysSpi22185)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _childrenNamesSpi22186;
		protected override global::java.lang.String[] childrenNamesSpi() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences_._childrenNamesSpi22186)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences_.staticClass, global::java.util.prefs.AbstractPreferences_._childrenNamesSpi22186)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _childSpi22187;
		protected override global::java.util.prefs.AbstractPreferences childSpi(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences_._childSpi22187, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.prefs.AbstractPreferences;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences_.staticClass, global::java.util.prefs.AbstractPreferences_._childSpi22187, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.prefs.AbstractPreferences;
		}
		internal static global::MonoJavaBridge.MethodId _syncSpi22188;
		protected override void syncSpi() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences_._syncSpi22188);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences_.staticClass, global::java.util.prefs.AbstractPreferences_._syncSpi22188);
		}
		internal static global::MonoJavaBridge.MethodId _flushSpi22189;
		protected override void flushSpi() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences_._flushSpi22189);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences_.staticClass, global::java.util.prefs.AbstractPreferences_._flushSpi22189);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.prefs.AbstractPreferences_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/prefs/AbstractPreferences"));
			global::java.util.prefs.AbstractPreferences_._putSpi22181 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences_.staticClass, "putSpi", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.util.prefs.AbstractPreferences_._getSpi22182 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences_.staticClass, "getSpi", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.util.prefs.AbstractPreferences_._removeSpi22183 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences_.staticClass, "removeSpi", "(Ljava/lang/String;)V");
			global::java.util.prefs.AbstractPreferences_._removeNodeSpi22184 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences_.staticClass, "removeNodeSpi", "()V");
			global::java.util.prefs.AbstractPreferences_._keysSpi22185 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences_.staticClass, "keysSpi", "()[Ljava/lang/String;");
			global::java.util.prefs.AbstractPreferences_._childrenNamesSpi22186 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences_.staticClass, "childrenNamesSpi", "()[Ljava/lang/String;");
			global::java.util.prefs.AbstractPreferences_._childSpi22187 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences_.staticClass, "childSpi", "(Ljava/lang/String;)Ljava/util/prefs/AbstractPreferences;");
			global::java.util.prefs.AbstractPreferences_._syncSpi22188 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences_.staticClass, "syncSpi", "()V");
			global::java.util.prefs.AbstractPreferences_._flushSpi22189 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences_.staticClass, "flushSpi", "()V");
		}
	}
}
