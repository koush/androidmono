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
		internal static global::net.sf.jni4net.jni.MethodId _get7598; 
		public virtual global::java.lang.Object get(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.SparseArray)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::android.util.SparseArray._get7598, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.util.SparseArray.staticClass, global::android.util.SparseArray._get7598, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _get7599; 
		public virtual global::java.lang.Object get(int arg0, java.lang.Object arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.SparseArray)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::android.util.SparseArray._get7599, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.util.SparseArray.staticClass, global::android.util.SparseArray._get7599, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _put7600; 
		public virtual void put(int arg0, java.lang.Object arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.SparseArray)) 
				@__env.CallVoidMethod(this, global::android.util.SparseArray._put7600, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.util.SparseArray.staticClass, global::android.util.SparseArray._put7600, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clear7601; 
		public virtual void clear() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.SparseArray)) 
				@__env.CallVoidMethod(this, global::android.util.SparseArray._clear7601); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.util.SparseArray.staticClass, global::android.util.SparseArray._clear7601); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _append7602; 
		public virtual void append(int arg0, java.lang.Object arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.SparseArray)) 
				@__env.CallVoidMethod(this, global::android.util.SparseArray._append7602, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.util.SparseArray.staticClass, global::android.util.SparseArray._append7602, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _size7603; 
		public virtual int size() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.SparseArray)) 
				return @__env.CallIntMethod(this, global::android.util.SparseArray._size7603); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.util.SparseArray.staticClass, global::android.util.SparseArray._size7603); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _remove7604; 
		public virtual void remove(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.SparseArray)) 
				@__env.CallVoidMethod(this, global::android.util.SparseArray._remove7604, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.util.SparseArray.staticClass, global::android.util.SparseArray._remove7604, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _delete7605; 
		public virtual void delete(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.SparseArray)) 
				@__env.CallVoidMethod(this, global::android.util.SparseArray._delete7605, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.util.SparseArray.staticClass, global::android.util.SparseArray._delete7605, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _keyAt7606; 
		public virtual int keyAt(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.SparseArray)) 
				return @__env.CallIntMethod(this, global::android.util.SparseArray._keyAt7606, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.util.SparseArray.staticClass, global::android.util.SparseArray._keyAt7606, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _valueAt7607; 
		public virtual global::java.lang.Object valueAt(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.SparseArray)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::android.util.SparseArray._valueAt7607, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.util.SparseArray.staticClass, global::android.util.SparseArray._valueAt7607, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setValueAt7608; 
		public virtual void setValueAt(int arg0, java.lang.Object arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.SparseArray)) 
				@__env.CallVoidMethod(this, global::android.util.SparseArray._setValueAt7608, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.util.SparseArray.staticClass, global::android.util.SparseArray._setValueAt7608, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _indexOfKey7609; 
		public virtual int indexOfKey(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.SparseArray)) 
				return @__env.CallIntMethod(this, global::android.util.SparseArray._indexOfKey7609, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.util.SparseArray.staticClass, global::android.util.SparseArray._indexOfKey7609, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _indexOfValue7610; 
		public virtual int indexOfValue(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.SparseArray)) 
				return @__env.CallIntMethod(this, global::android.util.SparseArray._indexOfValue7610, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.util.SparseArray.staticClass, global::android.util.SparseArray._indexOfValue7610, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SparseArray7611; 
		public SparseArray(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.util.SparseArray.staticClass, global::android.util.SparseArray._SparseArray7611, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SparseArray7612; 
		public SparseArray()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.util.SparseArray.staticClass, global::android.util.SparseArray._SparseArray7612, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.util.SparseArray.staticClass = @__class; 
			global::android.util.SparseArray._get7598 = @__env.GetMethodID(global::android.util.SparseArray.staticClass, "get", "(I)Ljava/lang/Object;"); 
			global::android.util.SparseArray._get7599 = @__env.GetMethodID(global::android.util.SparseArray.staticClass, "get", "(ILjava/lang/Object;)Ljava/lang/Object;"); 
			global::android.util.SparseArray._put7600 = @__env.GetMethodID(global::android.util.SparseArray.staticClass, "put", "(ILjava/lang/Object;)V"); 
			global::android.util.SparseArray._clear7601 = @__env.GetMethodID(global::android.util.SparseArray.staticClass, "clear", "()V"); 
			global::android.util.SparseArray._append7602 = @__env.GetMethodID(global::android.util.SparseArray.staticClass, "append", "(ILjava/lang/Object;)V"); 
			global::android.util.SparseArray._size7603 = @__env.GetMethodID(global::android.util.SparseArray.staticClass, "size", "()I"); 
			global::android.util.SparseArray._remove7604 = @__env.GetMethodID(global::android.util.SparseArray.staticClass, "remove", "(I)V"); 
			global::android.util.SparseArray._delete7605 = @__env.GetMethodID(global::android.util.SparseArray.staticClass, "delete", "(I)V"); 
			global::android.util.SparseArray._keyAt7606 = @__env.GetMethodID(global::android.util.SparseArray.staticClass, "keyAt", "(I)I"); 
			global::android.util.SparseArray._valueAt7607 = @__env.GetMethodID(global::android.util.SparseArray.staticClass, "valueAt", "(I)Ljava/lang/Object;"); 
			global::android.util.SparseArray._setValueAt7608 = @__env.GetMethodID(global::android.util.SparseArray.staticClass, "setValueAt", "(ILjava/lang/Object;)V"); 
			global::android.util.SparseArray._indexOfKey7609 = @__env.GetMethodID(global::android.util.SparseArray.staticClass, "indexOfKey", "(I)I"); 
			global::android.util.SparseArray._indexOfValue7610 = @__env.GetMethodID(global::android.util.SparseArray.staticClass, "indexOfValue", "(Ljava/lang/Object;)I"); 
			global::android.util.SparseArray._SparseArray7611 = @__env.GetMethodID(global::android.util.SparseArray.staticClass, "<init>", "(I)V"); 
			global::android.util.SparseArray._SparseArray7612 = @__env.GetMethodID(global::android.util.SparseArray.staticClass, "<init>", "()V"); 
		} 
	} 
} 
