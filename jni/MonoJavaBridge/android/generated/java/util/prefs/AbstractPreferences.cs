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
		internal static global::MonoJavaBridge.MethodId _name28115;
		public override global::java.lang.String name() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._name28115)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._name28115)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _parent28116;
		public override global::java.util.prefs.Preferences parent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._parent28116)) as java.util.prefs.Preferences;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._parent28116)) as java.util.prefs.Preferences;
		}
		internal static global::MonoJavaBridge.MethodId _get28117;
		public override global::java.lang.String get(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._get28117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._get28117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _put28118;
		public override void put(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._put28118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._put28118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _toString28119;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._toString28119)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._toString28119)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getBoolean28120;
		public override bool getBoolean(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._getBoolean28120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._getBoolean28120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putBoolean28121;
		public override void putBoolean(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._putBoolean28121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._putBoolean28121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getInt28122;
		public override int getInt(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._getInt28122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._getInt28122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putInt28123;
		public override void putInt(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._putInt28123, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._putInt28123, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getLong28124;
		public override long getLong(java.lang.String arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._getLong28124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._getLong28124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putLong28125;
		public override void putLong(java.lang.String arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._putLong28125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._putLong28125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFloat28126;
		public override float getFloat(java.lang.String arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._getFloat28126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._getFloat28126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putFloat28127;
		public override void putFloat(java.lang.String arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._putFloat28127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._putFloat28127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getDouble28128;
		public override double getDouble(java.lang.String arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._getDouble28128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._getDouble28128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putDouble28129;
		public override void putDouble(java.lang.String arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._putDouble28129, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._putDouble28129, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _clear28130;
		public override void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._clear28130);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._clear28130);
		}
		internal static global::MonoJavaBridge.MethodId _remove28131;
		public override void remove(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._remove28131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._remove28131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _keys28132;
		public override global::java.lang.String[] keys() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._keys28132)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._keys28132)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _flush28133;
		public override void flush() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._flush28133);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._flush28133);
		}
		internal static global::MonoJavaBridge.MethodId _sync28134;
		public override void sync() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._sync28134);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._sync28134);
		}
		internal static global::MonoJavaBridge.MethodId _putByteArray28135;
		public override void putByteArray(java.lang.String arg0, byte[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._putByteArray28135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._putByteArray28135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getByteArray28136;
		public override byte[] getByteArray(java.lang.String arg0, byte[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._getByteArray28136, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._getByteArray28136, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getChild28137;
		protected virtual global::java.util.prefs.AbstractPreferences getChild(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._getChild28137, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.prefs.AbstractPreferences;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._getChild28137, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.prefs.AbstractPreferences;
		}
		internal static global::MonoJavaBridge.MethodId _node28138;
		public override global::java.util.prefs.Preferences node(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._node28138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.prefs.Preferences;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._node28138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.prefs.Preferences;
		}
		internal static global::MonoJavaBridge.MethodId _absolutePath28139;
		public override global::java.lang.String absolutePath() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._absolutePath28139)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._absolutePath28139)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _childrenNames28140;
		public override global::java.lang.String[] childrenNames() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._childrenNames28140)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._childrenNames28140)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _cachedChildren28141;
		protected virtual global::java.util.prefs.AbstractPreferences[] cachedChildren() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.util.prefs.AbstractPreferences>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._cachedChildren28141)) as java.util.prefs.AbstractPreferences[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.util.prefs.AbstractPreferences>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._cachedChildren28141)) as java.util.prefs.AbstractPreferences[];
		}
		internal static global::MonoJavaBridge.MethodId _nodeExists28142;
		public override bool nodeExists(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._nodeExists28142, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._nodeExists28142, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeNode28143;
		public override void removeNode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._removeNode28143);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._removeNode28143);
		}
		internal static global::MonoJavaBridge.MethodId _isUserNode28144;
		public override bool isUserNode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._isUserNode28144);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._isUserNode28144);
		}
		internal static global::MonoJavaBridge.MethodId _addPreferenceChangeListener28145;
		public override void addPreferenceChangeListener(java.util.prefs.PreferenceChangeListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._addPreferenceChangeListener28145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._addPreferenceChangeListener28145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removePreferenceChangeListener28146;
		public override void removePreferenceChangeListener(java.util.prefs.PreferenceChangeListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._removePreferenceChangeListener28146, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._removePreferenceChangeListener28146, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addNodeChangeListener28147;
		public override void addNodeChangeListener(java.util.prefs.NodeChangeListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._addNodeChangeListener28147, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._addNodeChangeListener28147, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeNodeChangeListener28148;
		public override void removeNodeChangeListener(java.util.prefs.NodeChangeListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._removeNodeChangeListener28148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._removeNodeChangeListener28148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _putSpi28149;
		protected abstract void putSpi(java.lang.String arg0, java.lang.String arg1);
		internal static global::MonoJavaBridge.MethodId _getSpi28150;
		protected abstract global::java.lang.String getSpi(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _removeSpi28151;
		protected abstract void removeSpi(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _removeNodeSpi28152;
		protected abstract void removeNodeSpi();
		internal static global::MonoJavaBridge.MethodId _keysSpi28153;
		protected abstract global::java.lang.String[] keysSpi();
		internal static global::MonoJavaBridge.MethodId _childrenNamesSpi28154;
		protected abstract global::java.lang.String[] childrenNamesSpi();
		internal static global::MonoJavaBridge.MethodId _childSpi28155;
		protected abstract global::java.util.prefs.AbstractPreferences childSpi(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _syncSpi28156;
		protected abstract void syncSpi();
		internal static global::MonoJavaBridge.MethodId _flushSpi28157;
		protected abstract void flushSpi();
		internal static global::MonoJavaBridge.MethodId _isRemoved28158;
		protected virtual bool isRemoved() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._isRemoved28158);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._isRemoved28158);
		}
		internal static global::MonoJavaBridge.MethodId _exportNode28159;
		public override void exportNode(java.io.OutputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._exportNode28159, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._exportNode28159, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _exportSubtree28160;
		public override void exportSubtree(java.io.OutputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences._exportSubtree28160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._exportSubtree28160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _AbstractPreferences28161;
		protected AbstractPreferences(java.util.prefs.AbstractPreferences arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.prefs.AbstractPreferences.staticClass, global::java.util.prefs.AbstractPreferences._AbstractPreferences28161, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.prefs.AbstractPreferences.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/prefs/AbstractPreferences"));
			global::java.util.prefs.AbstractPreferences._name28115 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "name", "()Ljava/lang/String;");
			global::java.util.prefs.AbstractPreferences._parent28116 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "parent", "()Ljava/util/prefs/Preferences;");
			global::java.util.prefs.AbstractPreferences._get28117 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "get", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::java.util.prefs.AbstractPreferences._put28118 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "put", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.util.prefs.AbstractPreferences._toString28119 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.prefs.AbstractPreferences._getBoolean28120 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "getBoolean", "(Ljava/lang/String;Z)Z");
			global::java.util.prefs.AbstractPreferences._putBoolean28121 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "putBoolean", "(Ljava/lang/String;Z)V");
			global::java.util.prefs.AbstractPreferences._getInt28122 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "getInt", "(Ljava/lang/String;I)I");
			global::java.util.prefs.AbstractPreferences._putInt28123 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "putInt", "(Ljava/lang/String;I)V");
			global::java.util.prefs.AbstractPreferences._getLong28124 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "getLong", "(Ljava/lang/String;J)J");
			global::java.util.prefs.AbstractPreferences._putLong28125 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "putLong", "(Ljava/lang/String;J)V");
			global::java.util.prefs.AbstractPreferences._getFloat28126 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "getFloat", "(Ljava/lang/String;F)F");
			global::java.util.prefs.AbstractPreferences._putFloat28127 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "putFloat", "(Ljava/lang/String;F)V");
			global::java.util.prefs.AbstractPreferences._getDouble28128 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "getDouble", "(Ljava/lang/String;D)D");
			global::java.util.prefs.AbstractPreferences._putDouble28129 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "putDouble", "(Ljava/lang/String;D)V");
			global::java.util.prefs.AbstractPreferences._clear28130 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "clear", "()V");
			global::java.util.prefs.AbstractPreferences._remove28131 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "remove", "(Ljava/lang/String;)V");
			global::java.util.prefs.AbstractPreferences._keys28132 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "keys", "()[Ljava/lang/String;");
			global::java.util.prefs.AbstractPreferences._flush28133 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "flush", "()V");
			global::java.util.prefs.AbstractPreferences._sync28134 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "sync", "()V");
			global::java.util.prefs.AbstractPreferences._putByteArray28135 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "putByteArray", "(Ljava/lang/String;[B)V");
			global::java.util.prefs.AbstractPreferences._getByteArray28136 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "getByteArray", "(Ljava/lang/String;[B)[B");
			global::java.util.prefs.AbstractPreferences._getChild28137 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "getChild", "(Ljava/lang/String;)Ljava/util/prefs/AbstractPreferences;");
			global::java.util.prefs.AbstractPreferences._node28138 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "node", "(Ljava/lang/String;)Ljava/util/prefs/Preferences;");
			global::java.util.prefs.AbstractPreferences._absolutePath28139 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "absolutePath", "()Ljava/lang/String;");
			global::java.util.prefs.AbstractPreferences._childrenNames28140 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "childrenNames", "()[Ljava/lang/String;");
			global::java.util.prefs.AbstractPreferences._cachedChildren28141 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "cachedChildren", "()[Ljava/util/prefs/AbstractPreferences;");
			global::java.util.prefs.AbstractPreferences._nodeExists28142 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "nodeExists", "(Ljava/lang/String;)Z");
			global::java.util.prefs.AbstractPreferences._removeNode28143 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "removeNode", "()V");
			global::java.util.prefs.AbstractPreferences._isUserNode28144 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "isUserNode", "()Z");
			global::java.util.prefs.AbstractPreferences._addPreferenceChangeListener28145 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "addPreferenceChangeListener", "(Ljava/util/prefs/PreferenceChangeListener;)V");
			global::java.util.prefs.AbstractPreferences._removePreferenceChangeListener28146 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "removePreferenceChangeListener", "(Ljava/util/prefs/PreferenceChangeListener;)V");
			global::java.util.prefs.AbstractPreferences._addNodeChangeListener28147 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "addNodeChangeListener", "(Ljava/util/prefs/NodeChangeListener;)V");
			global::java.util.prefs.AbstractPreferences._removeNodeChangeListener28148 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "removeNodeChangeListener", "(Ljava/util/prefs/NodeChangeListener;)V");
			global::java.util.prefs.AbstractPreferences._putSpi28149 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "putSpi", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.util.prefs.AbstractPreferences._getSpi28150 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "getSpi", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.util.prefs.AbstractPreferences._removeSpi28151 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "removeSpi", "(Ljava/lang/String;)V");
			global::java.util.prefs.AbstractPreferences._removeNodeSpi28152 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "removeNodeSpi", "()V");
			global::java.util.prefs.AbstractPreferences._keysSpi28153 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "keysSpi", "()[Ljava/lang/String;");
			global::java.util.prefs.AbstractPreferences._childrenNamesSpi28154 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "childrenNamesSpi", "()[Ljava/lang/String;");
			global::java.util.prefs.AbstractPreferences._childSpi28155 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "childSpi", "(Ljava/lang/String;)Ljava/util/prefs/AbstractPreferences;");
			global::java.util.prefs.AbstractPreferences._syncSpi28156 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "syncSpi", "()V");
			global::java.util.prefs.AbstractPreferences._flushSpi28157 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "flushSpi", "()V");
			global::java.util.prefs.AbstractPreferences._isRemoved28158 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "isRemoved", "()Z");
			global::java.util.prefs.AbstractPreferences._exportNode28159 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "exportNode", "(Ljava/io/OutputStream;)V");
			global::java.util.prefs.AbstractPreferences._exportSubtree28160 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "exportSubtree", "(Ljava/io/OutputStream;)V");
			global::java.util.prefs.AbstractPreferences._AbstractPreferences28161 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences.staticClass, "<init>", "(Ljava/util/prefs/AbstractPreferences;Ljava/lang/String;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.prefs.AbstractPreferences))]
	internal sealed partial class AbstractPreferences_ : java.util.prefs.AbstractPreferences
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractPreferences_()
		{
			InitJNI();
		}
		internal AbstractPreferences_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _putSpi28162;
		protected override void putSpi(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences_._putSpi28162, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences_.staticClass, global::java.util.prefs.AbstractPreferences_._putSpi28162, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getSpi28163;
		protected override global::java.lang.String getSpi(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences_._getSpi28163, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences_.staticClass, global::java.util.prefs.AbstractPreferences_._getSpi28163, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _removeSpi28164;
		protected override void removeSpi(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences_._removeSpi28164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences_.staticClass, global::java.util.prefs.AbstractPreferences_._removeSpi28164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeNodeSpi28165;
		protected override void removeNodeSpi() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences_._removeNodeSpi28165);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences_.staticClass, global::java.util.prefs.AbstractPreferences_._removeNodeSpi28165);
		}
		internal static global::MonoJavaBridge.MethodId _keysSpi28166;
		protected override global::java.lang.String[] keysSpi() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences_._keysSpi28166)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences_.staticClass, global::java.util.prefs.AbstractPreferences_._keysSpi28166)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _childrenNamesSpi28167;
		protected override global::java.lang.String[] childrenNamesSpi() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences_._childrenNamesSpi28167)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences_.staticClass, global::java.util.prefs.AbstractPreferences_._childrenNamesSpi28167)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _childSpi28168;
		protected override global::java.util.prefs.AbstractPreferences childSpi(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences_._childSpi28168, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.prefs.AbstractPreferences;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences_.staticClass, global::java.util.prefs.AbstractPreferences_._childSpi28168, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.prefs.AbstractPreferences;
		}
		internal static global::MonoJavaBridge.MethodId _syncSpi28169;
		protected override void syncSpi() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences_._syncSpi28169);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences_.staticClass, global::java.util.prefs.AbstractPreferences_._syncSpi28169);
		}
		internal static global::MonoJavaBridge.MethodId _flushSpi28170;
		protected override void flushSpi() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences_._flushSpi28170);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.AbstractPreferences_.staticClass, global::java.util.prefs.AbstractPreferences_._flushSpi28170);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.prefs.AbstractPreferences_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/prefs/AbstractPreferences"));
			global::java.util.prefs.AbstractPreferences_._putSpi28162 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences_.staticClass, "putSpi", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.util.prefs.AbstractPreferences_._getSpi28163 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences_.staticClass, "getSpi", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.util.prefs.AbstractPreferences_._removeSpi28164 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences_.staticClass, "removeSpi", "(Ljava/lang/String;)V");
			global::java.util.prefs.AbstractPreferences_._removeNodeSpi28165 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences_.staticClass, "removeNodeSpi", "()V");
			global::java.util.prefs.AbstractPreferences_._keysSpi28166 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences_.staticClass, "keysSpi", "()[Ljava/lang/String;");
			global::java.util.prefs.AbstractPreferences_._childrenNamesSpi28167 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences_.staticClass, "childrenNamesSpi", "()[Ljava/lang/String;");
			global::java.util.prefs.AbstractPreferences_._childSpi28168 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences_.staticClass, "childSpi", "(Ljava/lang/String;)Ljava/util/prefs/AbstractPreferences;");
			global::java.util.prefs.AbstractPreferences_._syncSpi28169 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences_.staticClass, "syncSpi", "()V");
			global::java.util.prefs.AbstractPreferences_._flushSpi28170 = @__env.GetMethodIDNoThrow(global::java.util.prefs.AbstractPreferences_.staticClass, "flushSpi", "()V");
		}
	}
}
