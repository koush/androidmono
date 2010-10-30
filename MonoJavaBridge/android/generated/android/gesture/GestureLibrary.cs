namespace android.gesture
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.gesture.GestureLibrary_))]
	public abstract partial class GestureLibrary : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected GestureLibrary(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _load4885;
		public abstract bool load();
		internal static global::MonoJavaBridge.MethodId _save4886;
		public abstract bool save();
		internal static global::MonoJavaBridge.MethodId _isReadOnly4887;
		public virtual bool isReadOnly()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.gesture.GestureLibrary._isReadOnly4887.native == global::System.IntPtr.Zero)
				global::android.gesture.GestureLibrary._isReadOnly4887 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureLibrary.staticClass, "isReadOnly", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.gesture.GestureLibrary.staticClass, global::android.gesture.GestureLibrary._isReadOnly4887);
		}
		internal static global::MonoJavaBridge.MethodId _setOrientationStyle4888;
		public virtual void setOrientationStyle(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.gesture.GestureLibrary._setOrientationStyle4888.native == global::System.IntPtr.Zero)
				global::android.gesture.GestureLibrary._setOrientationStyle4888 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureLibrary.staticClass, "setOrientationStyle", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureLibrary.staticClass, global::android.gesture.GestureLibrary._setOrientationStyle4888, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getOrientationStyle4889;
		public virtual int getOrientationStyle()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.gesture.GestureLibrary._getOrientationStyle4889.native == global::System.IntPtr.Zero)
				global::android.gesture.GestureLibrary._getOrientationStyle4889 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureLibrary.staticClass, "getOrientationStyle", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.gesture.GestureLibrary.staticClass, global::android.gesture.GestureLibrary._getOrientationStyle4889);
		}
		internal static global::MonoJavaBridge.MethodId _setSequenceType4890;
		public virtual void setSequenceType(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.gesture.GestureLibrary._setSequenceType4890.native == global::System.IntPtr.Zero)
				global::android.gesture.GestureLibrary._setSequenceType4890 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureLibrary.staticClass, "setSequenceType", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureLibrary.staticClass, global::android.gesture.GestureLibrary._setSequenceType4890, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSequenceType4891;
		public virtual int getSequenceType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.gesture.GestureLibrary._getSequenceType4891.native == global::System.IntPtr.Zero)
				global::android.gesture.GestureLibrary._getSequenceType4891 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureLibrary.staticClass, "getSequenceType", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.gesture.GestureLibrary.staticClass, global::android.gesture.GestureLibrary._getSequenceType4891);
		}
		internal static global::MonoJavaBridge.MethodId _getGestureEntries4892;
		public virtual global::java.util.Set getGestureEntries()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.gesture.GestureLibrary._getGestureEntries4892.native == global::System.IntPtr.Zero)
				global::android.gesture.GestureLibrary._getGestureEntries4892 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureLibrary.staticClass, "getGestureEntries", "()Ljava/util/Set;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::android.gesture.GestureLibrary.staticClass, global::android.gesture.GestureLibrary._getGestureEntries4892) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _recognize4893;
		public virtual global::java.util.ArrayList recognize(android.gesture.Gesture arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.gesture.GestureLibrary._recognize4893.native == global::System.IntPtr.Zero)
				global::android.gesture.GestureLibrary._recognize4893 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureLibrary.staticClass, "recognize", "(Landroid/gesture/Gesture;)Ljava/util/ArrayList;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.gesture.GestureLibrary.staticClass, global::android.gesture.GestureLibrary._recognize4893, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.ArrayList;
		}
		internal static global::MonoJavaBridge.MethodId _addGesture4894;
		public virtual void addGesture(java.lang.String arg0, android.gesture.Gesture arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.gesture.GestureLibrary._addGesture4894.native == global::System.IntPtr.Zero)
				global::android.gesture.GestureLibrary._addGesture4894 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureLibrary.staticClass, "addGesture", "(Ljava/lang/String;Landroid/gesture/Gesture;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureLibrary.staticClass, global::android.gesture.GestureLibrary._addGesture4894, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _removeGesture4895;
		public virtual void removeGesture(java.lang.String arg0, android.gesture.Gesture arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.gesture.GestureLibrary._removeGesture4895.native == global::System.IntPtr.Zero)
				global::android.gesture.GestureLibrary._removeGesture4895 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureLibrary.staticClass, "removeGesture", "(Ljava/lang/String;Landroid/gesture/Gesture;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureLibrary.staticClass, global::android.gesture.GestureLibrary._removeGesture4895, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _removeEntry4896;
		public virtual void removeEntry(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.gesture.GestureLibrary._removeEntry4896.native == global::System.IntPtr.Zero)
				global::android.gesture.GestureLibrary._removeEntry4896 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureLibrary.staticClass, "removeEntry", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureLibrary.staticClass, global::android.gesture.GestureLibrary._removeEntry4896, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getGestures4897;
		public virtual global::java.util.ArrayList getGestures(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.gesture.GestureLibrary._getGestures4897.native == global::System.IntPtr.Zero)
				global::android.gesture.GestureLibrary._getGestures4897 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureLibrary.staticClass, "getGestures", "(Ljava/lang/String;)Ljava/util/ArrayList;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.gesture.GestureLibrary.staticClass, global::android.gesture.GestureLibrary._getGestures4897, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.ArrayList;
		}
		internal static global::MonoJavaBridge.MethodId _GestureLibrary4898;
		protected GestureLibrary() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.gesture.GestureLibrary._GestureLibrary4898.native == global::System.IntPtr.Zero)
				global::android.gesture.GestureLibrary._GestureLibrary4898 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureLibrary.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.gesture.GestureLibrary.staticClass, global::android.gesture.GestureLibrary._GestureLibrary4898);
			Init(@__env, handle);
		}
		static GestureLibrary()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.gesture.GestureLibrary.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/gesture/GestureLibrary"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.gesture.GestureLibrary))]
	internal sealed partial class GestureLibrary_ : android.gesture.GestureLibrary
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal GestureLibrary_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _load4899;
		public override bool load()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.gesture.GestureLibrary_._load4899.native == global::System.IntPtr.Zero)
				global::android.gesture.GestureLibrary_._load4899 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureLibrary_.staticClass, "load", "()Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::android.gesture.GestureLibrary_._load4899);
		}
		internal static global::MonoJavaBridge.MethodId _save4900;
		public override bool save()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.gesture.GestureLibrary_._save4900.native == global::System.IntPtr.Zero)
				global::android.gesture.GestureLibrary_._save4900 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureLibrary_.staticClass, "save", "()Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::android.gesture.GestureLibrary_._save4900);
		}
		static GestureLibrary_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.gesture.GestureLibrary_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/gesture/GestureLibrary"));
		}
		internal static void InitJNI()
		{
		}
	}
}
