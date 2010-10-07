namespace android.util
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class SparseArray : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static SparseArray()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.util.SparseArray), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.util.SparseArray(@__env);
			}
		}
		protected SparseArray(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _get8272;
		public virtual global::java.lang.Object get(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::android.util.SparseArray._get8272, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.util.SparseArray.staticClass, global::android.util.SparseArray._get8272, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _get8273;
		public virtual global::java.lang.Object get(int arg0, java.lang.Object arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::android.util.SparseArray._get8273, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.util.SparseArray.staticClass, global::android.util.SparseArray._get8273, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _put8274;
		public virtual void put(int arg0, java.lang.Object arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.util.SparseArray._put8274, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.util.SparseArray.staticClass, global::android.util.SparseArray._put8274, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _append8275;
		public virtual void append(int arg0, java.lang.Object arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.util.SparseArray._append8275, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.util.SparseArray.staticClass, global::android.util.SparseArray._append8275, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clear8276;
		public virtual void clear() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.util.SparseArray._clear8276);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.util.SparseArray.staticClass, global::android.util.SparseArray._clear8276);
		}
		internal static global::net.sf.jni4net.jni.MethodId _size8277;
		public virtual int size() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.util.SparseArray._size8277);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.util.SparseArray.staticClass, global::android.util.SparseArray._size8277);
		}
		internal static global::net.sf.jni4net.jni.MethodId _remove8278;
		public virtual void remove(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.util.SparseArray._remove8278, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.util.SparseArray.staticClass, global::android.util.SparseArray._remove8278, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _delete8279;
		public virtual void delete(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.util.SparseArray._delete8279, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.util.SparseArray.staticClass, global::android.util.SparseArray._delete8279, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _keyAt8280;
		public virtual int keyAt(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.util.SparseArray._keyAt8280, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.util.SparseArray.staticClass, global::android.util.SparseArray._keyAt8280, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _valueAt8281;
		public virtual global::java.lang.Object valueAt(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::android.util.SparseArray._valueAt8281, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.util.SparseArray.staticClass, global::android.util.SparseArray._valueAt8281, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setValueAt8282;
		public virtual void setValueAt(int arg0, java.lang.Object arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.util.SparseArray._setValueAt8282, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.util.SparseArray.staticClass, global::android.util.SparseArray._setValueAt8282, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _indexOfKey8283;
		public virtual int indexOfKey(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.util.SparseArray._indexOfKey8283, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.util.SparseArray.staticClass, global::android.util.SparseArray._indexOfKey8283, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _indexOfValue8284;
		public virtual int indexOfValue(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.util.SparseArray._indexOfValue8284, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.util.SparseArray.staticClass, global::android.util.SparseArray._indexOfValue8284, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _SparseArray8285;
		public SparseArray(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.util.SparseArray.staticClass, global::android.util.SparseArray._SparseArray8285, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _SparseArray8286;
		public SparseArray()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.util.SparseArray.staticClass, global::android.util.SparseArray._SparseArray8286, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.util.SparseArray.staticClass = @__class;
			global::android.util.SparseArray._get8272 = @__env.GetMethodID(global::android.util.SparseArray.staticClass, "get", "(I)Ljava/lang/Object;");
			global::android.util.SparseArray._get8273 = @__env.GetMethodID(global::android.util.SparseArray.staticClass, "get", "(ILjava/lang/Object;)Ljava/lang/Object;");
			global::android.util.SparseArray._put8274 = @__env.GetMethodID(global::android.util.SparseArray.staticClass, "put", "(ILjava/lang/Object;)V");
			global::android.util.SparseArray._append8275 = @__env.GetMethodID(global::android.util.SparseArray.staticClass, "append", "(ILjava/lang/Object;)V");
			global::android.util.SparseArray._clear8276 = @__env.GetMethodID(global::android.util.SparseArray.staticClass, "clear", "()V");
			global::android.util.SparseArray._size8277 = @__env.GetMethodID(global::android.util.SparseArray.staticClass, "size", "()I");
			global::android.util.SparseArray._remove8278 = @__env.GetMethodID(global::android.util.SparseArray.staticClass, "remove", "(I)V");
			global::android.util.SparseArray._delete8279 = @__env.GetMethodID(global::android.util.SparseArray.staticClass, "delete", "(I)V");
			global::android.util.SparseArray._keyAt8280 = @__env.GetMethodID(global::android.util.SparseArray.staticClass, "keyAt", "(I)I");
			global::android.util.SparseArray._valueAt8281 = @__env.GetMethodID(global::android.util.SparseArray.staticClass, "valueAt", "(I)Ljava/lang/Object;");
			global::android.util.SparseArray._setValueAt8282 = @__env.GetMethodID(global::android.util.SparseArray.staticClass, "setValueAt", "(ILjava/lang/Object;)V");
			global::android.util.SparseArray._indexOfKey8283 = @__env.GetMethodID(global::android.util.SparseArray.staticClass, "indexOfKey", "(I)I");
			global::android.util.SparseArray._indexOfValue8284 = @__env.GetMethodID(global::android.util.SparseArray.staticClass, "indexOfValue", "(Ljava/lang/Object;)I");
			global::android.util.SparseArray._SparseArray8285 = @__env.GetMethodID(global::android.util.SparseArray.staticClass, "<init>", "(I)V");
			global::android.util.SparseArray._SparseArray8286 = @__env.GetMethodID(global::android.util.SparseArray.staticClass, "<init>", "()V");
		}
	}
}
