namespace android.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SparseIntArray : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SparseIntArray(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get13864;
		public virtual int get(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.SparseIntArray._get13864, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._get13864, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _get13865;
		public virtual int get(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.SparseIntArray._get13865, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._get13865, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _put13866;
		public virtual void put(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.SparseIntArray._put13866, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._put13866, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _append13867;
		public virtual void append(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.SparseIntArray._append13867, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._append13867, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _clear13868;
		public virtual void clear()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.SparseIntArray._clear13868);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._clear13868);
		}
		internal static global::MonoJavaBridge.MethodId _size13869;
		public virtual int size()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.SparseIntArray._size13869);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._size13869);
		}
		internal static global::MonoJavaBridge.MethodId _delete13870;
		public virtual void delete(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.SparseIntArray._delete13870, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._delete13870, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _keyAt13871;
		public virtual int keyAt(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.SparseIntArray._keyAt13871, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._keyAt13871, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _valueAt13872;
		public virtual int valueAt(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.SparseIntArray._valueAt13872, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._valueAt13872, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _indexOfKey13873;
		public virtual int indexOfKey(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.SparseIntArray._indexOfKey13873, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._indexOfKey13873, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _indexOfValue13874;
		public virtual int indexOfValue(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.SparseIntArray._indexOfValue13874, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._indexOfValue13874, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAt13875;
		public virtual void removeAt(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.SparseIntArray._removeAt13875, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._removeAt13875, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _SparseIntArray13876;
		public SparseIntArray(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._SparseIntArray13876, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SparseIntArray13877;
		public SparseIntArray() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._SparseIntArray13877);
			Init(@__env, handle);
		}
		static SparseIntArray()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.SparseIntArray.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/SparseIntArray"));
			global::android.util.SparseIntArray._get13864 = @__env.GetMethodIDNoThrow(global::android.util.SparseIntArray.staticClass, "get", "(I)I");
			global::android.util.SparseIntArray._get13865 = @__env.GetMethodIDNoThrow(global::android.util.SparseIntArray.staticClass, "get", "(II)I");
			global::android.util.SparseIntArray._put13866 = @__env.GetMethodIDNoThrow(global::android.util.SparseIntArray.staticClass, "put", "(II)V");
			global::android.util.SparseIntArray._append13867 = @__env.GetMethodIDNoThrow(global::android.util.SparseIntArray.staticClass, "append", "(II)V");
			global::android.util.SparseIntArray._clear13868 = @__env.GetMethodIDNoThrow(global::android.util.SparseIntArray.staticClass, "clear", "()V");
			global::android.util.SparseIntArray._size13869 = @__env.GetMethodIDNoThrow(global::android.util.SparseIntArray.staticClass, "size", "()I");
			global::android.util.SparseIntArray._delete13870 = @__env.GetMethodIDNoThrow(global::android.util.SparseIntArray.staticClass, "delete", "(I)V");
			global::android.util.SparseIntArray._keyAt13871 = @__env.GetMethodIDNoThrow(global::android.util.SparseIntArray.staticClass, "keyAt", "(I)I");
			global::android.util.SparseIntArray._valueAt13872 = @__env.GetMethodIDNoThrow(global::android.util.SparseIntArray.staticClass, "valueAt", "(I)I");
			global::android.util.SparseIntArray._indexOfKey13873 = @__env.GetMethodIDNoThrow(global::android.util.SparseIntArray.staticClass, "indexOfKey", "(I)I");
			global::android.util.SparseIntArray._indexOfValue13874 = @__env.GetMethodIDNoThrow(global::android.util.SparseIntArray.staticClass, "indexOfValue", "(I)I");
			global::android.util.SparseIntArray._removeAt13875 = @__env.GetMethodIDNoThrow(global::android.util.SparseIntArray.staticClass, "removeAt", "(I)V");
			global::android.util.SparseIntArray._SparseIntArray13876 = @__env.GetMethodIDNoThrow(global::android.util.SparseIntArray.staticClass, "<init>", "(I)V");
			global::android.util.SparseIntArray._SparseIntArray13877 = @__env.GetMethodIDNoThrow(global::android.util.SparseIntArray.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
