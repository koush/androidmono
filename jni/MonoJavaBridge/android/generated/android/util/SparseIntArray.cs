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
		internal static global::MonoJavaBridge.MethodId _get13799;
		public virtual int get(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.SparseIntArray._get13799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._get13799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _get13800;
		public virtual int get(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.SparseIntArray._get13800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._get13800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _put13801;
		public virtual void put(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.SparseIntArray._put13801, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._put13801, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _append13802;
		public virtual void append(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.SparseIntArray._append13802, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._append13802, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _clear13803;
		public virtual void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.SparseIntArray._clear13803);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._clear13803);
		}
		internal static global::MonoJavaBridge.MethodId _size13804;
		public virtual int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.SparseIntArray._size13804);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._size13804);
		}
		internal static global::MonoJavaBridge.MethodId _delete13805;
		public virtual void delete(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.SparseIntArray._delete13805, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._delete13805, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _keyAt13806;
		public virtual int keyAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.SparseIntArray._keyAt13806, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._keyAt13806, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _valueAt13807;
		public virtual int valueAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.SparseIntArray._valueAt13807, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._valueAt13807, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _indexOfKey13808;
		public virtual int indexOfKey(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.SparseIntArray._indexOfKey13808, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._indexOfKey13808, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _indexOfValue13809;
		public virtual int indexOfValue(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.SparseIntArray._indexOfValue13809, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._indexOfValue13809, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAt13810;
		public virtual void removeAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.SparseIntArray._removeAt13810, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._removeAt13810, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _SparseIntArray13811;
		public SparseIntArray(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._SparseIntArray13811, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SparseIntArray13812;
		public SparseIntArray()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._SparseIntArray13812);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.SparseIntArray.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/SparseIntArray"));
			global::android.util.SparseIntArray._get13799 = @__env.GetMethodIDNoThrow(global::android.util.SparseIntArray.staticClass, "get", "(I)I");
			global::android.util.SparseIntArray._get13800 = @__env.GetMethodIDNoThrow(global::android.util.SparseIntArray.staticClass, "get", "(II)I");
			global::android.util.SparseIntArray._put13801 = @__env.GetMethodIDNoThrow(global::android.util.SparseIntArray.staticClass, "put", "(II)V");
			global::android.util.SparseIntArray._append13802 = @__env.GetMethodIDNoThrow(global::android.util.SparseIntArray.staticClass, "append", "(II)V");
			global::android.util.SparseIntArray._clear13803 = @__env.GetMethodIDNoThrow(global::android.util.SparseIntArray.staticClass, "clear", "()V");
			global::android.util.SparseIntArray._size13804 = @__env.GetMethodIDNoThrow(global::android.util.SparseIntArray.staticClass, "size", "()I");
			global::android.util.SparseIntArray._delete13805 = @__env.GetMethodIDNoThrow(global::android.util.SparseIntArray.staticClass, "delete", "(I)V");
			global::android.util.SparseIntArray._keyAt13806 = @__env.GetMethodIDNoThrow(global::android.util.SparseIntArray.staticClass, "keyAt", "(I)I");
			global::android.util.SparseIntArray._valueAt13807 = @__env.GetMethodIDNoThrow(global::android.util.SparseIntArray.staticClass, "valueAt", "(I)I");
			global::android.util.SparseIntArray._indexOfKey13808 = @__env.GetMethodIDNoThrow(global::android.util.SparseIntArray.staticClass, "indexOfKey", "(I)I");
			global::android.util.SparseIntArray._indexOfValue13809 = @__env.GetMethodIDNoThrow(global::android.util.SparseIntArray.staticClass, "indexOfValue", "(I)I");
			global::android.util.SparseIntArray._removeAt13810 = @__env.GetMethodIDNoThrow(global::android.util.SparseIntArray.staticClass, "removeAt", "(I)V");
			global::android.util.SparseIntArray._SparseIntArray13811 = @__env.GetMethodIDNoThrow(global::android.util.SparseIntArray.staticClass, "<init>", "(I)V");
			global::android.util.SparseIntArray._SparseIntArray13812 = @__env.GetMethodIDNoThrow(global::android.util.SparseIntArray.staticClass, "<init>", "()V");
		}
	}
}
