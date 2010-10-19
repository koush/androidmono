namespace android.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SparseBooleanArray : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SparseBooleanArray()
		{
			InitJNI();
		}
		protected SparseBooleanArray(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get9137;
		public virtual bool get(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.util.SparseBooleanArray._get9137, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._get9137, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _get9138;
		public virtual bool get(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.util.SparseBooleanArray._get9138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._get9138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _put9139;
		public virtual void put(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.SparseBooleanArray._put9139, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._put9139, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _append9140;
		public virtual void append(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.SparseBooleanArray._append9140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._append9140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _clear9141;
		public virtual void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.SparseBooleanArray._clear9141);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._clear9141);
		}
		internal static global::MonoJavaBridge.MethodId _size9142;
		public virtual int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.SparseBooleanArray._size9142);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._size9142);
		}
		internal static global::MonoJavaBridge.MethodId _delete9143;
		public virtual void delete(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.SparseBooleanArray._delete9143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._delete9143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _keyAt9144;
		public virtual int keyAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.SparseBooleanArray._keyAt9144, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._keyAt9144, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _valueAt9145;
		public virtual bool valueAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.util.SparseBooleanArray._valueAt9145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._valueAt9145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _indexOfKey9146;
		public virtual int indexOfKey(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.SparseBooleanArray._indexOfKey9146, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._indexOfKey9146, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _indexOfValue9147;
		public virtual int indexOfValue(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.SparseBooleanArray._indexOfValue9147, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._indexOfValue9147, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _SparseBooleanArray9148;
		public SparseBooleanArray(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._SparseBooleanArray9148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SparseBooleanArray9149;
		public SparseBooleanArray()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._SparseBooleanArray9149);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.SparseBooleanArray.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/SparseBooleanArray"));
			global::android.util.SparseBooleanArray._get9137 = @__env.GetMethodIDNoThrow(global::android.util.SparseBooleanArray.staticClass, "get", "(I)Z");
			global::android.util.SparseBooleanArray._get9138 = @__env.GetMethodIDNoThrow(global::android.util.SparseBooleanArray.staticClass, "get", "(IZ)Z");
			global::android.util.SparseBooleanArray._put9139 = @__env.GetMethodIDNoThrow(global::android.util.SparseBooleanArray.staticClass, "put", "(IZ)V");
			global::android.util.SparseBooleanArray._append9140 = @__env.GetMethodIDNoThrow(global::android.util.SparseBooleanArray.staticClass, "append", "(IZ)V");
			global::android.util.SparseBooleanArray._clear9141 = @__env.GetMethodIDNoThrow(global::android.util.SparseBooleanArray.staticClass, "clear", "()V");
			global::android.util.SparseBooleanArray._size9142 = @__env.GetMethodIDNoThrow(global::android.util.SparseBooleanArray.staticClass, "size", "()I");
			global::android.util.SparseBooleanArray._delete9143 = @__env.GetMethodIDNoThrow(global::android.util.SparseBooleanArray.staticClass, "delete", "(I)V");
			global::android.util.SparseBooleanArray._keyAt9144 = @__env.GetMethodIDNoThrow(global::android.util.SparseBooleanArray.staticClass, "keyAt", "(I)I");
			global::android.util.SparseBooleanArray._valueAt9145 = @__env.GetMethodIDNoThrow(global::android.util.SparseBooleanArray.staticClass, "valueAt", "(I)Z");
			global::android.util.SparseBooleanArray._indexOfKey9146 = @__env.GetMethodIDNoThrow(global::android.util.SparseBooleanArray.staticClass, "indexOfKey", "(I)I");
			global::android.util.SparseBooleanArray._indexOfValue9147 = @__env.GetMethodIDNoThrow(global::android.util.SparseBooleanArray.staticClass, "indexOfValue", "(Z)I");
			global::android.util.SparseBooleanArray._SparseBooleanArray9148 = @__env.GetMethodIDNoThrow(global::android.util.SparseBooleanArray.staticClass, "<init>", "(I)V");
			global::android.util.SparseBooleanArray._SparseBooleanArray9149 = @__env.GetMethodIDNoThrow(global::android.util.SparseBooleanArray.staticClass, "<init>", "()V");
		}
	}
}
