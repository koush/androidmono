namespace java.util
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class Observable : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static Observable()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.util.Observable), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::java.util.Observable(@__env);
			}
		}
		protected Observable(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _addObserver13781;
		public virtual void addObserver(java.util.Observer arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.util.Observable._addObserver13781, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.util.Observable.staticClass, global::java.util.Observable._addObserver13781, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _deleteObserver13782;
		public virtual void deleteObserver(java.util.Observer arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.util.Observable._deleteObserver13782, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.util.Observable.staticClass, global::java.util.Observable._deleteObserver13782, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _notifyObservers13783;
		public virtual void notifyObservers() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.util.Observable._notifyObservers13783);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.util.Observable.staticClass, global::java.util.Observable._notifyObservers13783);
		}
		internal static global::net.sf.jni4net.jni.MethodId _notifyObservers13784;
		public virtual void notifyObservers(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.util.Observable._notifyObservers13784, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.util.Observable.staticClass, global::java.util.Observable._notifyObservers13784, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _deleteObservers13785;
		public virtual void deleteObservers() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.util.Observable._deleteObservers13785);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.util.Observable.staticClass, global::java.util.Observable._deleteObservers13785);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setChanged13786;
		protected virtual void setChanged() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.util.Observable._setChanged13786);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.util.Observable.staticClass, global::java.util.Observable._setChanged13786);
		}
		internal static global::net.sf.jni4net.jni.MethodId _clearChanged13787;
		protected virtual void clearChanged() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.util.Observable._clearChanged13787);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.util.Observable.staticClass, global::java.util.Observable._clearChanged13787);
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasChanged13788;
		public virtual bool hasChanged() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.util.Observable._hasChanged13788);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.Observable.staticClass, global::java.util.Observable._hasChanged13788);
		}
		internal static global::net.sf.jni4net.jni.MethodId _countObservers13789;
		public virtual int countObservers() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.util.Observable._countObservers13789);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.util.Observable.staticClass, global::java.util.Observable._countObservers13789);
		}
		internal static global::net.sf.jni4net.jni.MethodId _Observable13790;
		public Observable()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.util.Observable.staticClass, global::java.util.Observable._Observable13790, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.util.Observable.staticClass = @__class;
			global::java.util.Observable._addObserver13781 = @__env.GetMethodID(global::java.util.Observable.staticClass, "addObserver", "(Ljava/util/Observer;)V");
			global::java.util.Observable._deleteObserver13782 = @__env.GetMethodID(global::java.util.Observable.staticClass, "deleteObserver", "(Ljava/util/Observer;)V");
			global::java.util.Observable._notifyObservers13783 = @__env.GetMethodID(global::java.util.Observable.staticClass, "notifyObservers", "()V");
			global::java.util.Observable._notifyObservers13784 = @__env.GetMethodID(global::java.util.Observable.staticClass, "notifyObservers", "(Ljava/lang/Object;)V");
			global::java.util.Observable._deleteObservers13785 = @__env.GetMethodID(global::java.util.Observable.staticClass, "deleteObservers", "()V");
			global::java.util.Observable._setChanged13786 = @__env.GetMethodID(global::java.util.Observable.staticClass, "setChanged", "()V");
			global::java.util.Observable._clearChanged13787 = @__env.GetMethodID(global::java.util.Observable.staticClass, "clearChanged", "()V");
			global::java.util.Observable._hasChanged13788 = @__env.GetMethodID(global::java.util.Observable.staticClass, "hasChanged", "()Z");
			global::java.util.Observable._countObservers13789 = @__env.GetMethodID(global::java.util.Observable.staticClass, "countObservers", "()I");
			global::java.util.Observable._Observable13790 = @__env.GetMethodID(global::java.util.Observable.staticClass, "<init>", "()V");
		}
	}
}
