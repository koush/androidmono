namespace android.gesture
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.gesture.GestureLibrary_))]
	public abstract partial class GestureLibrary : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static GestureLibrary()
		{
			InitJNI();
		}
		protected GestureLibrary(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _load4867;
		public abstract bool load();
		internal static global::MonoJavaBridge.MethodId _save4868;
		public abstract bool save();
		internal static global::MonoJavaBridge.MethodId _isReadOnly4869;
		public virtual bool isReadOnly() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.gesture.GestureLibrary._isReadOnly4869);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.gesture.GestureLibrary.staticClass, global::android.gesture.GestureLibrary._isReadOnly4869);
		}
		internal static global::MonoJavaBridge.MethodId _setOrientationStyle4870;
		public virtual void setOrientationStyle(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureLibrary._setOrientationStyle4870, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureLibrary.staticClass, global::android.gesture.GestureLibrary._setOrientationStyle4870, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getOrientationStyle4871;
		public virtual int getOrientationStyle() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.gesture.GestureLibrary._getOrientationStyle4871);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.gesture.GestureLibrary.staticClass, global::android.gesture.GestureLibrary._getOrientationStyle4871);
		}
		internal static global::MonoJavaBridge.MethodId _setSequenceType4872;
		public virtual void setSequenceType(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureLibrary._setSequenceType4872, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureLibrary.staticClass, global::android.gesture.GestureLibrary._setSequenceType4872, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSequenceType4873;
		public virtual int getSequenceType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.gesture.GestureLibrary._getSequenceType4873);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.gesture.GestureLibrary.staticClass, global::android.gesture.GestureLibrary._getSequenceType4873);
		}
		internal static global::MonoJavaBridge.MethodId _getGestureEntries4874;
		public virtual global::java.util.Set getGestureEntries() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::android.gesture.GestureLibrary._getGestureEntries4874)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.gesture.GestureLibrary.staticClass, global::android.gesture.GestureLibrary._getGestureEntries4874)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _recognize4875;
		public virtual global::java.util.ArrayList recognize(android.gesture.Gesture arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.gesture.GestureLibrary._recognize4875, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ArrayList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.gesture.GestureLibrary.staticClass, global::android.gesture.GestureLibrary._recognize4875, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ArrayList;
		}
		internal static global::MonoJavaBridge.MethodId _addGesture4876;
		public virtual void addGesture(java.lang.String arg0, android.gesture.Gesture arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureLibrary._addGesture4876, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureLibrary.staticClass, global::android.gesture.GestureLibrary._addGesture4876, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _removeGesture4877;
		public virtual void removeGesture(java.lang.String arg0, android.gesture.Gesture arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureLibrary._removeGesture4877, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureLibrary.staticClass, global::android.gesture.GestureLibrary._removeGesture4877, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _removeEntry4878;
		public virtual void removeEntry(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureLibrary._removeEntry4878, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureLibrary.staticClass, global::android.gesture.GestureLibrary._removeEntry4878, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getGestures4879;
		public virtual global::java.util.ArrayList getGestures(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.gesture.GestureLibrary._getGestures4879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ArrayList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.gesture.GestureLibrary.staticClass, global::android.gesture.GestureLibrary._getGestures4879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ArrayList;
		}
		internal static global::MonoJavaBridge.MethodId _GestureLibrary4880;
		protected GestureLibrary()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.gesture.GestureLibrary.staticClass, global::android.gesture.GestureLibrary._GestureLibrary4880);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.gesture.GestureLibrary.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/gesture/GestureLibrary"));
			global::android.gesture.GestureLibrary._load4867 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureLibrary.staticClass, "load", "()Z");
			global::android.gesture.GestureLibrary._save4868 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureLibrary.staticClass, "save", "()Z");
			global::android.gesture.GestureLibrary._isReadOnly4869 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureLibrary.staticClass, "isReadOnly", "()Z");
			global::android.gesture.GestureLibrary._setOrientationStyle4870 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureLibrary.staticClass, "setOrientationStyle", "(I)V");
			global::android.gesture.GestureLibrary._getOrientationStyle4871 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureLibrary.staticClass, "getOrientationStyle", "()I");
			global::android.gesture.GestureLibrary._setSequenceType4872 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureLibrary.staticClass, "setSequenceType", "(I)V");
			global::android.gesture.GestureLibrary._getSequenceType4873 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureLibrary.staticClass, "getSequenceType", "()I");
			global::android.gesture.GestureLibrary._getGestureEntries4874 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureLibrary.staticClass, "getGestureEntries", "()Ljava/util/Set;");
			global::android.gesture.GestureLibrary._recognize4875 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureLibrary.staticClass, "recognize", "(Landroid/gesture/Gesture;)Ljava/util/ArrayList;");
			global::android.gesture.GestureLibrary._addGesture4876 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureLibrary.staticClass, "addGesture", "(Ljava/lang/String;Landroid/gesture/Gesture;)V");
			global::android.gesture.GestureLibrary._removeGesture4877 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureLibrary.staticClass, "removeGesture", "(Ljava/lang/String;Landroid/gesture/Gesture;)V");
			global::android.gesture.GestureLibrary._removeEntry4878 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureLibrary.staticClass, "removeEntry", "(Ljava/lang/String;)V");
			global::android.gesture.GestureLibrary._getGestures4879 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureLibrary.staticClass, "getGestures", "(Ljava/lang/String;)Ljava/util/ArrayList;");
			global::android.gesture.GestureLibrary._GestureLibrary4880 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureLibrary.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.gesture.GestureLibrary))]
	public sealed partial class GestureLibrary_ : android.gesture.GestureLibrary
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static GestureLibrary_()
		{
			InitJNI();
		}
		internal GestureLibrary_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _load4881;
		public override bool load() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.gesture.GestureLibrary_._load4881);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.gesture.GestureLibrary_.staticClass, global::android.gesture.GestureLibrary_._load4881);
		}
		internal static global::MonoJavaBridge.MethodId _save4882;
		public override bool save() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.gesture.GestureLibrary_._save4882);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.gesture.GestureLibrary_.staticClass, global::android.gesture.GestureLibrary_._save4882);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.gesture.GestureLibrary_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/gesture/GestureLibrary"));
			global::android.gesture.GestureLibrary_._load4881 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureLibrary_.staticClass, "load", "()Z");
			global::android.gesture.GestureLibrary_._save4882 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureLibrary_.staticClass, "save", "()Z");
		}
	}
}
