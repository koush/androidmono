namespace android.gesture 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class GestureLibrary : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static GestureLibrary() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.gesture.GestureLibrary), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected GestureLibrary(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _load2595; 
		public abstract bool load(); 
		internal static global::net.sf.jni4net.jni.MethodId _save2596; 
		public abstract bool save(); 
		internal static global::net.sf.jni4net.jni.MethodId _isReadOnly2597; 
		public virtual bool isReadOnly() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.gesture.GestureLibrary._isReadOnly2597); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.gesture.GestureLibrary.staticClass, global::android.gesture.GestureLibrary._isReadOnly2597); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOrientationStyle2598; 
		public virtual void setOrientationStyle(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.gesture.GestureLibrary._setOrientationStyle2598, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.gesture.GestureLibrary.staticClass, global::android.gesture.GestureLibrary._setOrientationStyle2598, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOrientationStyle2599; 
		public virtual int getOrientationStyle() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.gesture.GestureLibrary._getOrientationStyle2599); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.gesture.GestureLibrary.staticClass, global::android.gesture.GestureLibrary._getOrientationStyle2599); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSequenceType2600; 
		public virtual void setSequenceType(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.gesture.GestureLibrary._setSequenceType2600, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.gesture.GestureLibrary.staticClass, global::android.gesture.GestureLibrary._setSequenceType2600, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSequenceType2601; 
		public virtual int getSequenceType() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.gesture.GestureLibrary._getSequenceType2601); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.gesture.GestureLibrary.staticClass, global::android.gesture.GestureLibrary._getSequenceType2601); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGestureEntries2602; 
		public virtual global::java.util.Set getGestureEntries() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallObjectMethodPtr(this, global::android.gesture.GestureLibrary._getGestureEntries2602)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.gesture.GestureLibrary.staticClass, global::android.gesture.GestureLibrary._getGestureEntries2602)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _recognize2603; 
		public virtual global::java.util.ArrayList recognize(android.gesture.Gesture arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallObjectMethodPtr(this, global::android.gesture.GestureLibrary._recognize2603, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.gesture.GestureLibrary.staticClass, global::android.gesture.GestureLibrary._recognize2603, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addGesture2604; 
		public virtual void addGesture(java.lang.String arg0, android.gesture.Gesture arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.gesture.GestureLibrary._addGesture2604, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.gesture.GestureLibrary.staticClass, global::android.gesture.GestureLibrary._addGesture2604, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeGesture2605; 
		public virtual void removeGesture(java.lang.String arg0, android.gesture.Gesture arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.gesture.GestureLibrary._removeGesture2605, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.gesture.GestureLibrary.staticClass, global::android.gesture.GestureLibrary._removeGesture2605, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeEntry2606; 
		public virtual void removeEntry(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.gesture.GestureLibrary._removeEntry2606, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.gesture.GestureLibrary.staticClass, global::android.gesture.GestureLibrary._removeEntry2606, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGestures2607; 
		public virtual global::java.util.ArrayList getGestures(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallObjectMethodPtr(this, global::android.gesture.GestureLibrary._getGestures2607, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.gesture.GestureLibrary.staticClass, global::android.gesture.GestureLibrary._getGestures2607, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _GestureLibrary2608; 
		protected GestureLibrary()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.gesture.GestureLibrary.staticClass, global::android.gesture.GestureLibrary._GestureLibrary2608, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.gesture.GestureLibrary.staticClass = @__class; 
			global::android.gesture.GestureLibrary._load2595 = @__env.GetMethodID(global::android.gesture.GestureLibrary.staticClass, "load", "()Z"); 
			global::android.gesture.GestureLibrary._save2596 = @__env.GetMethodID(global::android.gesture.GestureLibrary.staticClass, "save", "()Z"); 
			global::android.gesture.GestureLibrary._isReadOnly2597 = @__env.GetMethodID(global::android.gesture.GestureLibrary.staticClass, "isReadOnly", "()Z"); 
			global::android.gesture.GestureLibrary._setOrientationStyle2598 = @__env.GetMethodID(global::android.gesture.GestureLibrary.staticClass, "setOrientationStyle", "(I)V"); 
			global::android.gesture.GestureLibrary._getOrientationStyle2599 = @__env.GetMethodID(global::android.gesture.GestureLibrary.staticClass, "getOrientationStyle", "()I"); 
			global::android.gesture.GestureLibrary._setSequenceType2600 = @__env.GetMethodID(global::android.gesture.GestureLibrary.staticClass, "setSequenceType", "(I)V"); 
			global::android.gesture.GestureLibrary._getSequenceType2601 = @__env.GetMethodID(global::android.gesture.GestureLibrary.staticClass, "getSequenceType", "()I"); 
			global::android.gesture.GestureLibrary._getGestureEntries2602 = @__env.GetMethodID(global::android.gesture.GestureLibrary.staticClass, "getGestureEntries", "()Ljava/util/Set;"); 
			global::android.gesture.GestureLibrary._recognize2603 = @__env.GetMethodID(global::android.gesture.GestureLibrary.staticClass, "recognize", "(Landroid/gesture/Gesture;)Ljava/util/ArrayList;"); 
			global::android.gesture.GestureLibrary._addGesture2604 = @__env.GetMethodID(global::android.gesture.GestureLibrary.staticClass, "addGesture", "(Ljava/lang/String;Landroid/gesture/Gesture;)V"); 
			global::android.gesture.GestureLibrary._removeGesture2605 = @__env.GetMethodID(global::android.gesture.GestureLibrary.staticClass, "removeGesture", "(Ljava/lang/String;Landroid/gesture/Gesture;)V"); 
			global::android.gesture.GestureLibrary._removeEntry2606 = @__env.GetMethodID(global::android.gesture.GestureLibrary.staticClass, "removeEntry", "(Ljava/lang/String;)V"); 
			global::android.gesture.GestureLibrary._getGestures2607 = @__env.GetMethodID(global::android.gesture.GestureLibrary.staticClass, "getGestures", "(Ljava/lang/String;)Ljava/util/ArrayList;"); 
			global::android.gesture.GestureLibrary._GestureLibrary2608 = @__env.GetMethodID(global::android.gesture.GestureLibrary.staticClass, "<init>", "()V"); 
		} 
	} 
} 
