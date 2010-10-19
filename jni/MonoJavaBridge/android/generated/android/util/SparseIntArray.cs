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
		internal static global::MonoJavaBridge.MethodId _get9150;
		public virtual int get(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.SparseIntArray._get9150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._get9150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _get9151;
		public virtual int get(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.SparseIntArray._get9151, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._get9151, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _put9152;
		public virtual void put(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.SparseIntArray._put9152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._put9152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _append9153;
		public virtual void append(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.SparseIntArray._append9153, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._append9153, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _clear9154;
		public virtual void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.SparseIntArray._clear9154);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._clear9154);
		}
		internal static global::MonoJavaBridge.MethodId _size9155;
		public virtual int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.SparseIntArray._size9155);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._size9155);
		}
		internal static global::MonoJavaBridge.MethodId _delete9156;
		public virtual void delete(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.SparseIntArray._delete9156, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._delete9156, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _keyAt9157;
		public virtual int keyAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.SparseIntArray._keyAt9157, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._keyAt9157, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _valueAt9158;
		public virtual int valueAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.SparseIntArray._valueAt9158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._valueAt9158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _indexOfKey9159;
		public virtual int indexOfKey(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.SparseIntArray._indexOfKey9159, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._indexOfKey9159, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _indexOfValue9160;
		public virtual int indexOfValue(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.SparseIntArray._indexOfValue9160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._indexOfValue9160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAt9161;
		public virtual void removeAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.SparseIntArray._removeAt9161, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._removeAt9161, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _SparseIntArray9162;
		public SparseIntArray(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._SparseIntArray9162, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SparseIntArray9163;
		public SparseIntArray()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._SparseIntArray9163);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.SparseIntArray.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/SparseIntArray"));
			global::android.util.SparseIntArray._get9150 = @__env.GetMethodIDNoThrow(global::android.util.SparseIntArray.staticClass, "get", "(I)I");
			global::android.util.SparseIntArray._get9151 = @__env.GetMethodIDNoThrow(global::android.util.SparseIntArray.staticClass, "get", "(II)I");
			global::android.util.SparseIntArray._put9152 = @__env.GetMethodIDNoThrow(global::android.util.SparseIntArray.staticClass, "put", "(II)V");
			global::android.util.SparseIntArray._append9153 = @__env.GetMethodIDNoThrow(global::android.util.SparseIntArray.staticClass, "append", "(II)V");
			global::android.util.SparseIntArray._clear9154 = @__env.GetMethodIDNoThrow(global::android.util.SparseIntArray.staticClass, "clear", "()V");
			global::android.util.SparseIntArray._size9155 = @__env.GetMethodIDNoThrow(global::android.util.SparseIntArray.staticClass, "size", "()I");
			global::android.util.SparseIntArray._delete9156 = @__env.GetMethodIDNoThrow(global::android.util.SparseIntArray.staticClass, "delete", "(I)V");
			global::android.util.SparseIntArray._keyAt9157 = @__env.GetMethodIDNoThrow(global::android.util.SparseIntArray.staticClass, "keyAt", "(I)I");
			global::android.util.SparseIntArray._valueAt9158 = @__env.GetMethodIDNoThrow(global::android.util.SparseIntArray.staticClass, "valueAt", "(I)I");
			global::android.util.SparseIntArray._indexOfKey9159 = @__env.GetMethodIDNoThrow(global::android.util.SparseIntArray.staticClass, "indexOfKey", "(I)I");
			global::android.util.SparseIntArray._indexOfValue9160 = @__env.GetMethodIDNoThrow(global::android.util.SparseIntArray.staticClass, "indexOfValue", "(I)I");
			global::android.util.SparseIntArray._removeAt9161 = @__env.GetMethodIDNoThrow(global::android.util.SparseIntArray.staticClass, "removeAt", "(I)V");
			global::android.util.SparseIntArray._SparseIntArray9162 = @__env.GetMethodIDNoThrow(global::android.util.SparseIntArray.staticClass, "<init>", "(I)V");
			global::android.util.SparseIntArray._SparseIntArray9163 = @__env.GetMethodIDNoThrow(global::android.util.SparseIntArray.staticClass, "<init>", "()V");
		}
	}
}
