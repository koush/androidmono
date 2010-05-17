namespace android.util 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class SparseArray : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static SparseArray() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.util.SparseArray), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _get7195; 
		public virtual java.lang.Object get(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.SparseArray)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _get7195, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.util.SparseArray.staticClass, _get7195, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _get7196; 
		public virtual java.lang.Object get(int arg0, java.lang.Object arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.SparseArray)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _get7196, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.util.SparseArray.staticClass, _get7196, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _put7197; 
		public virtual void put(int arg0, java.lang.Object arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.SparseArray)) 
				@__env.CallVoidMethod(this, _put7197, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.util.SparseArray.staticClass, _put7197, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clear7198; 
		public virtual void clear() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.SparseArray)) 
				@__env.CallVoidMethod(this, _clear7198); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.util.SparseArray.staticClass, _clear7198); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _append7199; 
		public virtual void append(int arg0, java.lang.Object arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.SparseArray)) 
				@__env.CallVoidMethod(this, _append7199, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.util.SparseArray.staticClass, _append7199, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _size7200; 
		public virtual int size() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.SparseArray)) 
				return @__env.CallIntMethod(this, _size7200); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.util.SparseArray.staticClass, _size7200); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _remove7201; 
		public virtual void remove(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.SparseArray)) 
				@__env.CallVoidMethod(this, _remove7201, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.util.SparseArray.staticClass, _remove7201, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _delete7202; 
		public virtual void delete(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.SparseArray)) 
				@__env.CallVoidMethod(this, _delete7202, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.util.SparseArray.staticClass, _delete7202, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _keyAt7203; 
		public virtual int keyAt(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.SparseArray)) 
				return @__env.CallIntMethod(this, _keyAt7203, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.util.SparseArray.staticClass, _keyAt7203, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _valueAt7204; 
		public virtual java.lang.Object valueAt(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.SparseArray)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _valueAt7204, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.util.SparseArray.staticClass, _valueAt7204, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setValueAt7205; 
		public virtual void setValueAt(int arg0, java.lang.Object arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.SparseArray)) 
				@__env.CallVoidMethod(this, _setValueAt7205, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.util.SparseArray.staticClass, _setValueAt7205, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _indexOfKey7206; 
		public virtual int indexOfKey(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.SparseArray)) 
				return @__env.CallIntMethod(this, _indexOfKey7206, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.util.SparseArray.staticClass, _indexOfKey7206, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _indexOfValue7207; 
		public virtual int indexOfValue(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.SparseArray)) 
				return @__env.CallIntMethod(this, _indexOfValue7207, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.util.SparseArray.staticClass, _indexOfValue7207, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SparseArray7208; 
		public SparseArray(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.util.SparseArray.staticClass, _SparseArray7208, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SparseArray7209; 
		public SparseArray()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.util.SparseArray.staticClass, _SparseArray7209, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.util.SparseArray.staticClass = @__class; 
			global::android.util.SparseArray._get7195 = @__env.GetMethodID(global::android.util.SparseArray.staticClass, "get", "(I)Ljava/lang/Object;"); 
			global::android.util.SparseArray._get7196 = @__env.GetMethodID(global::android.util.SparseArray.staticClass, "get", "(ILjava/lang/Object;)Ljava/lang/Object;"); 
			global::android.util.SparseArray._put7197 = @__env.GetMethodID(global::android.util.SparseArray.staticClass, "put", "(ILjava/lang/Object;)V"); 
			global::android.util.SparseArray._clear7198 = @__env.GetMethodID(global::android.util.SparseArray.staticClass, "clear", "()V"); 
			global::android.util.SparseArray._append7199 = @__env.GetMethodID(global::android.util.SparseArray.staticClass, "append", "(ILjava/lang/Object;)V"); 
			global::android.util.SparseArray._size7200 = @__env.GetMethodID(global::android.util.SparseArray.staticClass, "size", "()I"); 
			global::android.util.SparseArray._remove7201 = @__env.GetMethodID(global::android.util.SparseArray.staticClass, "remove", "(I)V"); 
			global::android.util.SparseArray._delete7202 = @__env.GetMethodID(global::android.util.SparseArray.staticClass, "delete", "(I)V"); 
			global::android.util.SparseArray._keyAt7203 = @__env.GetMethodID(global::android.util.SparseArray.staticClass, "keyAt", "(I)I"); 
			global::android.util.SparseArray._valueAt7204 = @__env.GetMethodID(global::android.util.SparseArray.staticClass, "valueAt", "(I)Ljava/lang/Object;"); 
			global::android.util.SparseArray._setValueAt7205 = @__env.GetMethodID(global::android.util.SparseArray.staticClass, "setValueAt", "(ILjava/lang/Object;)V"); 
			global::android.util.SparseArray._indexOfKey7206 = @__env.GetMethodID(global::android.util.SparseArray.staticClass, "indexOfKey", "(I)I"); 
			global::android.util.SparseArray._indexOfValue7207 = @__env.GetMethodID(global::android.util.SparseArray.staticClass, "indexOfValue", "(Ljava/lang/Object;)I"); 
			global::android.util.SparseArray._SparseArray7208 = @__env.GetMethodID(global::android.util.SparseArray.staticClass, "<init>", "(I)V"); 
			global::android.util.SparseArray._SparseArray7209 = @__env.GetMethodID(global::android.util.SparseArray.staticClass, "<init>", "()V"); 
		} 
	} 
} 
