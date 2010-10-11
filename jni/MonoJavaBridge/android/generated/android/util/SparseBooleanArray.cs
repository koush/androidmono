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
		internal static global::MonoJavaBridge.MethodId _get8591;
		public virtual bool get(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.util.SparseBooleanArray._get8591, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._get8591, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _get8592;
		public virtual bool get(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.util.SparseBooleanArray._get8592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._get8592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _put8593;
		public virtual void put(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.SparseBooleanArray._put8593, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._put8593, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _append8594;
		public virtual void append(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.SparseBooleanArray._append8594, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._append8594, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _clear8595;
		public virtual void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.SparseBooleanArray._clear8595);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._clear8595);
		}
		internal static global::MonoJavaBridge.MethodId _size8596;
		public virtual int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.SparseBooleanArray._size8596);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._size8596);
		}
		internal static global::MonoJavaBridge.MethodId _delete8597;
		public virtual void delete(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.SparseBooleanArray._delete8597, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._delete8597, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _keyAt8598;
		public virtual int keyAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.SparseBooleanArray._keyAt8598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._keyAt8598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _valueAt8599;
		public virtual bool valueAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.util.SparseBooleanArray._valueAt8599, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._valueAt8599, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _indexOfKey8600;
		public virtual int indexOfKey(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.SparseBooleanArray._indexOfKey8600, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._indexOfKey8600, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _indexOfValue8601;
		public virtual int indexOfValue(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.SparseBooleanArray._indexOfValue8601, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._indexOfValue8601, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _SparseBooleanArray8602;
		public SparseBooleanArray(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._SparseBooleanArray8602, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SparseBooleanArray8603;
		public SparseBooleanArray()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._SparseBooleanArray8603);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.SparseBooleanArray.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/SparseBooleanArray"));
			global::android.util.SparseBooleanArray._get8591 = @__env.GetMethodIDNoThrow(global::android.util.SparseBooleanArray.staticClass, "get", "(I)Z");
			global::android.util.SparseBooleanArray._get8592 = @__env.GetMethodIDNoThrow(global::android.util.SparseBooleanArray.staticClass, "get", "(IZ)Z");
			global::android.util.SparseBooleanArray._put8593 = @__env.GetMethodIDNoThrow(global::android.util.SparseBooleanArray.staticClass, "put", "(IZ)V");
			global::android.util.SparseBooleanArray._append8594 = @__env.GetMethodIDNoThrow(global::android.util.SparseBooleanArray.staticClass, "append", "(IZ)V");
			global::android.util.SparseBooleanArray._clear8595 = @__env.GetMethodIDNoThrow(global::android.util.SparseBooleanArray.staticClass, "clear", "()V");
			global::android.util.SparseBooleanArray._size8596 = @__env.GetMethodIDNoThrow(global::android.util.SparseBooleanArray.staticClass, "size", "()I");
			global::android.util.SparseBooleanArray._delete8597 = @__env.GetMethodIDNoThrow(global::android.util.SparseBooleanArray.staticClass, "delete", "(I)V");
			global::android.util.SparseBooleanArray._keyAt8598 = @__env.GetMethodIDNoThrow(global::android.util.SparseBooleanArray.staticClass, "keyAt", "(I)I");
			global::android.util.SparseBooleanArray._valueAt8599 = @__env.GetMethodIDNoThrow(global::android.util.SparseBooleanArray.staticClass, "valueAt", "(I)Z");
			global::android.util.SparseBooleanArray._indexOfKey8600 = @__env.GetMethodIDNoThrow(global::android.util.SparseBooleanArray.staticClass, "indexOfKey", "(I)I");
			global::android.util.SparseBooleanArray._indexOfValue8601 = @__env.GetMethodIDNoThrow(global::android.util.SparseBooleanArray.staticClass, "indexOfValue", "(Z)I");
			global::android.util.SparseBooleanArray._SparseBooleanArray8602 = @__env.GetMethodIDNoThrow(global::android.util.SparseBooleanArray.staticClass, "<init>", "(I)V");
			global::android.util.SparseBooleanArray._SparseBooleanArray8603 = @__env.GetMethodIDNoThrow(global::android.util.SparseBooleanArray.staticClass, "<init>", "()V");
		}
	}
}
