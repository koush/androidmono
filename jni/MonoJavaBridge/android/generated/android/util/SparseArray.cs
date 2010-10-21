namespace android.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SparseArray : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SparseArray()
		{
			InitJNI();
		}
		protected SparseArray(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get13771;
		public virtual global::java.lang.Object get(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.util.SparseArray._get13771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.util.SparseArray.staticClass, global::android.util.SparseArray._get13771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _get13772;
		public virtual global::java.lang.Object get(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.util.SparseArray._get13772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.util.SparseArray.staticClass, global::android.util.SparseArray._get13772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _put13773;
		public virtual void put(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.SparseArray._put13773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.SparseArray.staticClass, global::android.util.SparseArray._put13773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _append13774;
		public virtual void append(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.SparseArray._append13774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.SparseArray.staticClass, global::android.util.SparseArray._append13774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _clear13775;
		public virtual void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.SparseArray._clear13775);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.SparseArray.staticClass, global::android.util.SparseArray._clear13775);
		}
		internal static global::MonoJavaBridge.MethodId _size13776;
		public virtual int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.SparseArray._size13776);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.SparseArray.staticClass, global::android.util.SparseArray._size13776);
		}
		internal static global::MonoJavaBridge.MethodId _remove13777;
		public virtual void remove(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.SparseArray._remove13777, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.SparseArray.staticClass, global::android.util.SparseArray._remove13777, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _delete13778;
		public virtual void delete(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.SparseArray._delete13778, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.SparseArray.staticClass, global::android.util.SparseArray._delete13778, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _keyAt13779;
		public virtual int keyAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.SparseArray._keyAt13779, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.SparseArray.staticClass, global::android.util.SparseArray._keyAt13779, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _valueAt13780;
		public virtual global::java.lang.Object valueAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.util.SparseArray._valueAt13780, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.util.SparseArray.staticClass, global::android.util.SparseArray._valueAt13780, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setValueAt13781;
		public virtual void setValueAt(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.SparseArray._setValueAt13781, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.SparseArray.staticClass, global::android.util.SparseArray._setValueAt13781, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _indexOfKey13782;
		public virtual int indexOfKey(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.SparseArray._indexOfKey13782, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.SparseArray.staticClass, global::android.util.SparseArray._indexOfKey13782, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _indexOfValue13783;
		public virtual int indexOfValue(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.SparseArray._indexOfValue13783, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.SparseArray.staticClass, global::android.util.SparseArray._indexOfValue13783, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _SparseArray13784;
		public SparseArray(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.SparseArray.staticClass, global::android.util.SparseArray._SparseArray13784, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SparseArray13785;
		public SparseArray()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.SparseArray.staticClass, global::android.util.SparseArray._SparseArray13785);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.SparseArray.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/SparseArray"));
			global::android.util.SparseArray._get13771 = @__env.GetMethodIDNoThrow(global::android.util.SparseArray.staticClass, "get", "(I)Ljava/lang/Object;");
			global::android.util.SparseArray._get13772 = @__env.GetMethodIDNoThrow(global::android.util.SparseArray.staticClass, "get", "(ILjava/lang/Object;)Ljava/lang/Object;");
			global::android.util.SparseArray._put13773 = @__env.GetMethodIDNoThrow(global::android.util.SparseArray.staticClass, "put", "(ILjava/lang/Object;)V");
			global::android.util.SparseArray._append13774 = @__env.GetMethodIDNoThrow(global::android.util.SparseArray.staticClass, "append", "(ILjava/lang/Object;)V");
			global::android.util.SparseArray._clear13775 = @__env.GetMethodIDNoThrow(global::android.util.SparseArray.staticClass, "clear", "()V");
			global::android.util.SparseArray._size13776 = @__env.GetMethodIDNoThrow(global::android.util.SparseArray.staticClass, "size", "()I");
			global::android.util.SparseArray._remove13777 = @__env.GetMethodIDNoThrow(global::android.util.SparseArray.staticClass, "remove", "(I)V");
			global::android.util.SparseArray._delete13778 = @__env.GetMethodIDNoThrow(global::android.util.SparseArray.staticClass, "delete", "(I)V");
			global::android.util.SparseArray._keyAt13779 = @__env.GetMethodIDNoThrow(global::android.util.SparseArray.staticClass, "keyAt", "(I)I");
			global::android.util.SparseArray._valueAt13780 = @__env.GetMethodIDNoThrow(global::android.util.SparseArray.staticClass, "valueAt", "(I)Ljava/lang/Object;");
			global::android.util.SparseArray._setValueAt13781 = @__env.GetMethodIDNoThrow(global::android.util.SparseArray.staticClass, "setValueAt", "(ILjava/lang/Object;)V");
			global::android.util.SparseArray._indexOfKey13782 = @__env.GetMethodIDNoThrow(global::android.util.SparseArray.staticClass, "indexOfKey", "(I)I");
			global::android.util.SparseArray._indexOfValue13783 = @__env.GetMethodIDNoThrow(global::android.util.SparseArray.staticClass, "indexOfValue", "(Ljava/lang/Object;)I");
			global::android.util.SparseArray._SparseArray13784 = @__env.GetMethodIDNoThrow(global::android.util.SparseArray.staticClass, "<init>", "(I)V");
			global::android.util.SparseArray._SparseArray13785 = @__env.GetMethodIDNoThrow(global::android.util.SparseArray.staticClass, "<init>", "()V");
		}
	}
}
