namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class BaseAdapter : java.lang.Object, ListAdapter, SpinnerAdapter
	{ 
		internal static global::java.lang.Class staticClass; 
		static BaseAdapter() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.BaseAdapter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected BaseAdapter(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCount9943; 
		public abstract int getCount(); 
		internal static global::net.sf.jni4net.jni.MethodId _getItem9944; 
		public abstract global::java.lang.Object getItem(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getItemId9945; 
		public abstract long getItemId(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getView9946; 
		public abstract global::android.view.View getView(int arg0, android.view.View arg1, android.view.ViewGroup arg2); 
		internal static global::net.sf.jni4net.jni.MethodId _isEmpty9947; 
		public virtual bool isEmpty() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.widget.BaseAdapter._isEmpty9947); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.BaseAdapter.staticClass, global::android.widget.BaseAdapter._isEmpty9947); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isEnabled9948; 
		public virtual bool isEnabled(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.widget.BaseAdapter._isEnabled9948, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.BaseAdapter.staticClass, global::android.widget.BaseAdapter._isEnabled9948, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _registerDataSetObserver9949; 
		public virtual void registerDataSetObserver(android.database.DataSetObserver arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.BaseAdapter._registerDataSetObserver9949, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.BaseAdapter.staticClass, global::android.widget.BaseAdapter._registerDataSetObserver9949, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unregisterDataSetObserver9950; 
		public virtual void unregisterDataSetObserver(android.database.DataSetObserver arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.BaseAdapter._unregisterDataSetObserver9950, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.BaseAdapter.staticClass, global::android.widget.BaseAdapter._unregisterDataSetObserver9950, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _areAllItemsEnabled9951; 
		public virtual bool areAllItemsEnabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.widget.BaseAdapter._areAllItemsEnabled9951); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.BaseAdapter.staticClass, global::android.widget.BaseAdapter._areAllItemsEnabled9951); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasStableIds9952; 
		public virtual bool hasStableIds() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.widget.BaseAdapter._hasStableIds9952); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.BaseAdapter.staticClass, global::android.widget.BaseAdapter._hasStableIds9952); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getItemViewType9953; 
		public virtual int getItemViewType(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.widget.BaseAdapter._getItemViewType9953, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.BaseAdapter.staticClass, global::android.widget.BaseAdapter._getItemViewType9953, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getViewTypeCount9954; 
		public virtual int getViewTypeCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.widget.BaseAdapter._getViewTypeCount9954); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.BaseAdapter.staticClass, global::android.widget.BaseAdapter._getViewTypeCount9954); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDropDownView9955; 
		public virtual global::android.view.View getDropDownView(int arg0, android.view.View arg1, android.view.ViewGroup arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.BaseAdapter._getDropDownView9955, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.BaseAdapter.staticClass, global::android.widget.BaseAdapter._getDropDownView9955, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _notifyDataSetChanged9956; 
		public virtual void notifyDataSetChanged() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.BaseAdapter._notifyDataSetChanged9956); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.BaseAdapter.staticClass, global::android.widget.BaseAdapter._notifyDataSetChanged9956); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _notifyDataSetInvalidated9957; 
		public virtual void notifyDataSetInvalidated() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.BaseAdapter._notifyDataSetInvalidated9957); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.BaseAdapter.staticClass, global::android.widget.BaseAdapter._notifyDataSetInvalidated9957); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _BaseAdapter9958; 
		public BaseAdapter()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.BaseAdapter.staticClass, global::android.widget.BaseAdapter._BaseAdapter9958, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.BaseAdapter.staticClass = @__class; 
			global::android.widget.BaseAdapter._getCount9943 = @__env.GetMethodID(global::android.widget.BaseAdapter.staticClass, "getCount", "()I"); 
			global::android.widget.BaseAdapter._getItem9944 = @__env.GetMethodID(global::android.widget.BaseAdapter.staticClass, "getItem", "(I)Ljava/lang/Object;"); 
			global::android.widget.BaseAdapter._getItemId9945 = @__env.GetMethodID(global::android.widget.BaseAdapter.staticClass, "getItemId", "(I)J"); 
			global::android.widget.BaseAdapter._getView9946 = @__env.GetMethodID(global::android.widget.BaseAdapter.staticClass, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;"); 
			global::android.widget.BaseAdapter._isEmpty9947 = @__env.GetMethodID(global::android.widget.BaseAdapter.staticClass, "isEmpty", "()Z"); 
			global::android.widget.BaseAdapter._isEnabled9948 = @__env.GetMethodID(global::android.widget.BaseAdapter.staticClass, "isEnabled", "(I)Z"); 
			global::android.widget.BaseAdapter._registerDataSetObserver9949 = @__env.GetMethodID(global::android.widget.BaseAdapter.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V"); 
			global::android.widget.BaseAdapter._unregisterDataSetObserver9950 = @__env.GetMethodID(global::android.widget.BaseAdapter.staticClass, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V"); 
			global::android.widget.BaseAdapter._areAllItemsEnabled9951 = @__env.GetMethodID(global::android.widget.BaseAdapter.staticClass, "areAllItemsEnabled", "()Z"); 
			global::android.widget.BaseAdapter._hasStableIds9952 = @__env.GetMethodID(global::android.widget.BaseAdapter.staticClass, "hasStableIds", "()Z"); 
			global::android.widget.BaseAdapter._getItemViewType9953 = @__env.GetMethodID(global::android.widget.BaseAdapter.staticClass, "getItemViewType", "(I)I"); 
			global::android.widget.BaseAdapter._getViewTypeCount9954 = @__env.GetMethodID(global::android.widget.BaseAdapter.staticClass, "getViewTypeCount", "()I"); 
			global::android.widget.BaseAdapter._getDropDownView9955 = @__env.GetMethodID(global::android.widget.BaseAdapter.staticClass, "getDropDownView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;"); 
			global::android.widget.BaseAdapter._notifyDataSetChanged9956 = @__env.GetMethodID(global::android.widget.BaseAdapter.staticClass, "notifyDataSetChanged", "()V"); 
			global::android.widget.BaseAdapter._notifyDataSetInvalidated9957 = @__env.GetMethodID(global::android.widget.BaseAdapter.staticClass, "notifyDataSetInvalidated", "()V"); 
			global::android.widget.BaseAdapter._BaseAdapter9958 = @__env.GetMethodID(global::android.widget.BaseAdapter.staticClass, "<init>", "()V"); 
		} 
	} 
} 
