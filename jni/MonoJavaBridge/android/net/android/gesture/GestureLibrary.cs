namespace android.gesture 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class GestureLibrary : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static GestureLibrary() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.gesture.GestureLibrary), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected GestureLibrary(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _load2402; 
		public abstract bool load(); 
		internal static global::net.sf.jni4net.jni.MethodId _save2403; 
		public abstract bool save(); 
		internal static global::net.sf.jni4net.jni.MethodId _isReadOnly2404; 
		public virtual bool isReadOnly() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureLibrary)) 
				return @__env.CallBooleanMethod(this, _isReadOnly2404); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.gesture.GestureLibrary.staticClass, _isReadOnly2404); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOrientationStyle2405; 
		public virtual void setOrientationStyle(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureLibrary)) 
				@__env.CallVoidMethod(this, _setOrientationStyle2405, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureLibrary.staticClass, _setOrientationStyle2405, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOrientationStyle2406; 
		public virtual int getOrientationStyle() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureLibrary)) 
				return @__env.CallIntMethod(this, _getOrientationStyle2406); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.gesture.GestureLibrary.staticClass, _getOrientationStyle2406); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSequenceType2407; 
		public virtual void setSequenceType(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureLibrary)) 
				@__env.CallVoidMethod(this, _setSequenceType2407, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureLibrary.staticClass, _setSequenceType2407, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSequenceType2408; 
		public virtual int getSequenceType() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureLibrary)) 
				return @__env.CallIntMethod(this, _getSequenceType2408); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.gesture.GestureLibrary.staticClass, _getSequenceType2408); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGestureEntries2409; 
		public virtual java.util.Set getGestureEntries() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureLibrary)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallObjectMethodPtr(this, _getGestureEntries2409)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.gesture.GestureLibrary.staticClass, _getGestureEntries2409)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _recognize2410; 
		public virtual java.util.ArrayList recognize(android.gesture.Gesture arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureLibrary)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallObjectMethodPtr(this, _recognize2410, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.gesture.GestureLibrary.staticClass, _recognize2410, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addGesture2411; 
		public virtual void addGesture(java.lang.String arg0, android.gesture.Gesture arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureLibrary)) 
				@__env.CallVoidMethod(this, _addGesture2411, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureLibrary.staticClass, _addGesture2411, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeGesture2412; 
		public virtual void removeGesture(java.lang.String arg0, android.gesture.Gesture arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureLibrary)) 
				@__env.CallVoidMethod(this, _removeGesture2412, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureLibrary.staticClass, _removeGesture2412, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeEntry2413; 
		public virtual void removeEntry(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureLibrary)) 
				@__env.CallVoidMethod(this, _removeEntry2413, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureLibrary.staticClass, _removeEntry2413, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGestures2414; 
		public virtual java.util.ArrayList getGestures(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureLibrary)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallObjectMethodPtr(this, _getGestures2414, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.gesture.GestureLibrary.staticClass, _getGestures2414, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _GestureLibrary2415; 
		protected GestureLibrary()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.gesture.GestureLibrary.staticClass, _GestureLibrary2415, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.gesture.GestureLibrary.staticClass = @__class; 
			global::android.gesture.GestureLibrary._load2402 = @__env.GetMethodID(global::android.gesture.GestureLibrary.staticClass, "load", "()Z"); 
			global::android.gesture.GestureLibrary._save2403 = @__env.GetMethodID(global::android.gesture.GestureLibrary.staticClass, "save", "()Z"); 
			global::android.gesture.GestureLibrary._isReadOnly2404 = @__env.GetMethodID(global::android.gesture.GestureLibrary.staticClass, "isReadOnly", "()Z"); 
			global::android.gesture.GestureLibrary._setOrientationStyle2405 = @__env.GetMethodID(global::android.gesture.GestureLibrary.staticClass, "setOrientationStyle", "(I)V"); 
			global::android.gesture.GestureLibrary._getOrientationStyle2406 = @__env.GetMethodID(global::android.gesture.GestureLibrary.staticClass, "getOrientationStyle", "()I"); 
			global::android.gesture.GestureLibrary._setSequenceType2407 = @__env.GetMethodID(global::android.gesture.GestureLibrary.staticClass, "setSequenceType", "(I)V"); 
			global::android.gesture.GestureLibrary._getSequenceType2408 = @__env.GetMethodID(global::android.gesture.GestureLibrary.staticClass, "getSequenceType", "()I"); 
			global::android.gesture.GestureLibrary._getGestureEntries2409 = @__env.GetMethodID(global::android.gesture.GestureLibrary.staticClass, "getGestureEntries", "()Ljava/util/Set;"); 
			global::android.gesture.GestureLibrary._recognize2410 = @__env.GetMethodID(global::android.gesture.GestureLibrary.staticClass, "recognize", "(Landroid/gesture/Gesture;)Ljava/util/ArrayList;"); 
			global::android.gesture.GestureLibrary._addGesture2411 = @__env.GetMethodID(global::android.gesture.GestureLibrary.staticClass, "addGesture", "(Ljava/lang/String;Landroid/gesture/Gesture;)V"); 
			global::android.gesture.GestureLibrary._removeGesture2412 = @__env.GetMethodID(global::android.gesture.GestureLibrary.staticClass, "removeGesture", "(Ljava/lang/String;Landroid/gesture/Gesture;)V"); 
			global::android.gesture.GestureLibrary._removeEntry2413 = @__env.GetMethodID(global::android.gesture.GestureLibrary.staticClass, "removeEntry", "(Ljava/lang/String;)V"); 
			global::android.gesture.GestureLibrary._getGestures2414 = @__env.GetMethodID(global::android.gesture.GestureLibrary.staticClass, "getGestures", "(Ljava/lang/String;)Ljava/util/ArrayList;"); 
			global::android.gesture.GestureLibrary._GestureLibrary2415 = @__env.GetMethodID(global::android.gesture.GestureLibrary.staticClass, "<init>", "()V"); 
		} 
	} 
} 
