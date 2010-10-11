namespace android.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SparseIntArray : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SparseIntArray()
		{
			InitJNI();
		}
		protected SparseIntArray(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get8604;
		public virtual int get(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.SparseIntArray._get8604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._get8604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _get8605;
		public virtual int get(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.SparseIntArray._get8605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._get8605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _put8606;
		public virtual void put(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.SparseIntArray._put8606, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._put8606, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _append8607;
		public virtual void append(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.SparseIntArray._append8607, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._append8607, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _clear8608;
		public virtual void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.SparseIntArray._clear8608);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._clear8608);
		}
		internal static global::MonoJavaBridge.MethodId _size8609;
		public virtual int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.SparseIntArray._size8609);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._size8609);
		}
		internal static global::MonoJavaBridge.MethodId _delete8610;
		public virtual void delete(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.SparseIntArray._delete8610, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._delete8610, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _keyAt8611;
		public virtual int keyAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.SparseIntArray._keyAt8611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._keyAt8611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _valueAt8612;
		public virtual int valueAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.SparseIntArray._valueAt8612, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._valueAt8612, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _indexOfKey8613;
		public virtual int indexOfKey(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.SparseIntArray._indexOfKey8613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._indexOfKey8613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _indexOfValue8614;
		public virtual int indexOfValue(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.SparseIntArray._indexOfValue8614, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._indexOfValue8614, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAt8615;
		public virtual void removeAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.SparseIntArray._removeAt8615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._removeAt8615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _SparseIntArray8616;
		public SparseIntArray(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._SparseIntArray8616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SparseIntArray8617;
		public SparseIntArray()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._SparseIntArray8617);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.SparseIntArray.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/SparseIntArray"));
			global::android.util.SparseIntArray._get8604 = @__env.GetMethodIDNoThrow(global::android.util.SparseIntArray.staticClass, "get", "(I)I");
			global::android.util.SparseIntArray._get8605 = @__env.GetMethodIDNoThrow(global::android.util.SparseIntArray.staticClass, "get", "(II)I");
			global::android.util.SparseIntArray._put8606 = @__env.GetMethodIDNoThrow(global::android.util.SparseIntArray.staticClass, "put", "(II)V");
			global::android.util.SparseIntArray._append8607 = @__env.GetMethodIDNoThrow(global::android.util.SparseIntArray.staticClass, "append", "(II)V");
			global::android.util.SparseIntArray._clear8608 = @__env.GetMethodIDNoThrow(global::android.util.SparseIntArray.staticClass, "clear", "()V");
			global::android.util.SparseIntArray._size8609 = @__env.GetMethodIDNoThrow(global::android.util.SparseIntArray.staticClass, "size", "()I");
			global::android.util.SparseIntArray._delete8610 = @__env.GetMethodIDNoThrow(global::android.util.SparseIntArray.staticClass, "delete", "(I)V");
			global::android.util.SparseIntArray._keyAt8611 = @__env.GetMethodIDNoThrow(global::android.util.SparseIntArray.staticClass, "keyAt", "(I)I");
			global::android.util.SparseIntArray._valueAt8612 = @__env.GetMethodIDNoThrow(global::android.util.SparseIntArray.staticClass, "valueAt", "(I)I");
			global::android.util.SparseIntArray._indexOfKey8613 = @__env.GetMethodIDNoThrow(global::android.util.SparseIntArray.staticClass, "indexOfKey", "(I)I");
			global::android.util.SparseIntArray._indexOfValue8614 = @__env.GetMethodIDNoThrow(global::android.util.SparseIntArray.staticClass, "indexOfValue", "(I)I");
			global::android.util.SparseIntArray._removeAt8615 = @__env.GetMethodIDNoThrow(global::android.util.SparseIntArray.staticClass, "removeAt", "(I)V");
			global::android.util.SparseIntArray._SparseIntArray8616 = @__env.GetMethodIDNoThrow(global::android.util.SparseIntArray.staticClass, "<init>", "(I)V");
			global::android.util.SparseIntArray._SparseIntArray8617 = @__env.GetMethodIDNoThrow(global::android.util.SparseIntArray.staticClass, "<init>", "()V");
		}
	}
}
