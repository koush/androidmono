namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LinkedList : java.util.AbstractSequentialList, List, java.lang.Cloneable, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static LinkedList()
		{
			InitJNI();
		}
		protected LinkedList(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add26347;
		public override bool add(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.LinkedList._add26347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._add26347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _add26348;
		public override void add(int arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.LinkedList._add26348, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._add26348, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _get26349;
		public override global::java.lang.Object get(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.LinkedList._get26349, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._get26349, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _clone26350;
		public virtual global::java.lang.Object clone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.LinkedList._clone26350)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._clone26350)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _indexOf26351;
		public override int indexOf(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.LinkedList._indexOf26351, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._indexOf26351, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clear26352;
		public override void clear()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.LinkedList._clear26352);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._clear26352);
		}
		internal static global::MonoJavaBridge.MethodId _lastIndexOf26353;
		public override int lastIndexOf(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.LinkedList._lastIndexOf26353, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._lastIndexOf26353, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _contains26354;
		public override bool contains(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.LinkedList._contains26354, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._contains26354, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll26355;
		public override bool addAll(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.LinkedList._addAll26355, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._addAll26355, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll26356;
		public override bool addAll(int arg0, java.util.Collection arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.LinkedList._addAll26356, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._addAll26356, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _size26357;
		public override int size()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.LinkedList._size26357);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._size26357);
		}
		internal static global::MonoJavaBridge.MethodId _toArray26358;
		public override global::java.lang.Object[] toArray(java.lang.Object[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.LinkedList._toArray26358, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._toArray26358, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray26359;
		public override global::java.lang.Object[] toArray()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.LinkedList._toArray26359)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._toArray26359)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _push26360;
		public virtual void push(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.LinkedList._push26360, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._push26360, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _pop26361;
		public virtual global::java.lang.Object pop()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.LinkedList._pop26361)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._pop26361)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remove26362;
		public override global::java.lang.Object remove(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.LinkedList._remove26362, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._remove26362, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remove26363;
		public override bool remove(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.LinkedList._remove26363, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._remove26363, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _remove26364;
		public virtual global::java.lang.Object remove()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.LinkedList._remove26364)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._remove26364)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _set26365;
		public override global::java.lang.Object set(int arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.LinkedList._set26365, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._set26365, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _listIterator26366;
		public override global::java.util.ListIterator listIterator(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.ListIterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.LinkedList._listIterator26366, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ListIterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.ListIterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._listIterator26366, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ListIterator;
		}
		internal static global::MonoJavaBridge.MethodId _poll26367;
		public virtual global::java.lang.Object poll()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.LinkedList._poll26367)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._poll26367)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _peek26368;
		public virtual global::java.lang.Object peek()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.LinkedList._peek26368)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._peek26368)) as java.lang.Object;
		}
		public new global::java.lang.Object First
		{
			get
			{
				return getFirst();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFirst26369;
		public virtual global::java.lang.Object getFirst()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.LinkedList._getFirst26369)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._getFirst26369)) as java.lang.Object;
		}
		public new global::java.lang.Object Last
		{
			get
			{
				return getLast();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLast26370;
		public virtual global::java.lang.Object getLast()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.LinkedList._getLast26370)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._getLast26370)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _removeFirst26371;
		public virtual global::java.lang.Object removeFirst()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.LinkedList._removeFirst26371)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._removeFirst26371)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _removeLast26372;
		public virtual global::java.lang.Object removeLast()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.LinkedList._removeLast26372)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._removeLast26372)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _addFirst26373;
		public virtual void addFirst(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.LinkedList._addFirst26373, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._addFirst26373, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addLast26374;
		public virtual void addLast(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.LinkedList._addLast26374, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._addLast26374, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _element26375;
		public virtual global::java.lang.Object element()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.LinkedList._element26375)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._element26375)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _offer26376;
		public virtual bool offer(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.LinkedList._offer26376, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._offer26376, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _offerFirst26377;
		public virtual bool offerFirst(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.LinkedList._offerFirst26377, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._offerFirst26377, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _offerLast26378;
		public virtual bool offerLast(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.LinkedList._offerLast26378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._offerLast26378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _peekFirst26379;
		public virtual global::java.lang.Object peekFirst()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.LinkedList._peekFirst26379)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._peekFirst26379)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _peekLast26380;
		public virtual global::java.lang.Object peekLast()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.LinkedList._peekLast26380)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._peekLast26380)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _pollFirst26381;
		public virtual global::java.lang.Object pollFirst()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.LinkedList._pollFirst26381)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._pollFirst26381)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _pollLast26382;
		public virtual global::java.lang.Object pollLast()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.LinkedList._pollLast26382)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._pollLast26382)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _removeFirstOccurrence26383;
		public virtual bool removeFirstOccurrence(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.LinkedList._removeFirstOccurrence26383, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._removeFirstOccurrence26383, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeLastOccurrence26384;
		public virtual bool removeLastOccurrence(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.LinkedList._removeLastOccurrence26384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._removeLastOccurrence26384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _descendingIterator26385;
		public virtual global::java.util.Iterator descendingIterator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.LinkedList._descendingIterator26385)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._descendingIterator26385)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _LinkedList26386;
		public LinkedList(java.util.Collection arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.LinkedList.staticClass, global::java.util.LinkedList._LinkedList26386, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _LinkedList26387;
		public LinkedList() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.LinkedList.staticClass, global::java.util.LinkedList._LinkedList26387);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.LinkedList.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/LinkedList"));
			global::java.util.LinkedList._add26347 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.LinkedList._add26348 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "add", "(ILjava/lang/Object;)V");
			global::java.util.LinkedList._get26349 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "get", "(I)Ljava/lang/Object;");
			global::java.util.LinkedList._clone26350 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.util.LinkedList._indexOf26351 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "indexOf", "(Ljava/lang/Object;)I");
			global::java.util.LinkedList._clear26352 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "clear", "()V");
			global::java.util.LinkedList._lastIndexOf26353 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "lastIndexOf", "(Ljava/lang/Object;)I");
			global::java.util.LinkedList._contains26354 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.LinkedList._addAll26355 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "addAll", "(Ljava/util/Collection;)Z");
			global::java.util.LinkedList._addAll26356 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "addAll", "(ILjava/util/Collection;)Z");
			global::java.util.LinkedList._size26357 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "size", "()I");
			global::java.util.LinkedList._toArray26358 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			global::java.util.LinkedList._toArray26359 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "toArray", "()[Ljava/lang/Object;");
			global::java.util.LinkedList._push26360 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "push", "(Ljava/lang/Object;)V");
			global::java.util.LinkedList._pop26361 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "pop", "()Ljava/lang/Object;");
			global::java.util.LinkedList._remove26362 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "remove", "(I)Ljava/lang/Object;");
			global::java.util.LinkedList._remove26363 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.LinkedList._remove26364 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "remove", "()Ljava/lang/Object;");
			global::java.util.LinkedList._set26365 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "set", "(ILjava/lang/Object;)Ljava/lang/Object;");
			global::java.util.LinkedList._listIterator26366 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "listIterator", "(I)Ljava/util/ListIterator;");
			global::java.util.LinkedList._poll26367 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "poll", "()Ljava/lang/Object;");
			global::java.util.LinkedList._peek26368 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "peek", "()Ljava/lang/Object;");
			global::java.util.LinkedList._getFirst26369 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "getFirst", "()Ljava/lang/Object;");
			global::java.util.LinkedList._getLast26370 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "getLast", "()Ljava/lang/Object;");
			global::java.util.LinkedList._removeFirst26371 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "removeFirst", "()Ljava/lang/Object;");
			global::java.util.LinkedList._removeLast26372 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "removeLast", "()Ljava/lang/Object;");
			global::java.util.LinkedList._addFirst26373 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "addFirst", "(Ljava/lang/Object;)V");
			global::java.util.LinkedList._addLast26374 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "addLast", "(Ljava/lang/Object;)V");
			global::java.util.LinkedList._element26375 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "element", "()Ljava/lang/Object;");
			global::java.util.LinkedList._offer26376 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "offer", "(Ljava/lang/Object;)Z");
			global::java.util.LinkedList._offerFirst26377 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "offerFirst", "(Ljava/lang/Object;)Z");
			global::java.util.LinkedList._offerLast26378 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "offerLast", "(Ljava/lang/Object;)Z");
			global::java.util.LinkedList._peekFirst26379 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "peekFirst", "()Ljava/lang/Object;");
			global::java.util.LinkedList._peekLast26380 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "peekLast", "()Ljava/lang/Object;");
			global::java.util.LinkedList._pollFirst26381 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "pollFirst", "()Ljava/lang/Object;");
			global::java.util.LinkedList._pollLast26382 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "pollLast", "()Ljava/lang/Object;");
			global::java.util.LinkedList._removeFirstOccurrence26383 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "removeFirstOccurrence", "(Ljava/lang/Object;)Z");
			global::java.util.LinkedList._removeLastOccurrence26384 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "removeLastOccurrence", "(Ljava/lang/Object;)Z");
			global::java.util.LinkedList._descendingIterator26385 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "descendingIterator", "()Ljava/util/Iterator;");
			global::java.util.LinkedList._LinkedList26386 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "<init>", "(Ljava/util/Collection;)V");
			global::java.util.LinkedList._LinkedList26387 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "<init>", "()V");
		}
	}
}
