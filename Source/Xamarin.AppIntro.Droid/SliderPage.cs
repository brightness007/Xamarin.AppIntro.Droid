using Android.Runtime;
using Java.Interop;
using System;

namespace Com.Github.Appintro.Model
{
    public sealed partial class SliderPage
	{
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.appintro.model']/class[@name='SliderPage']/constructor[@name='SliderPage' and count(parameter)=11 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='java.lang.CharSequence'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int'] and parameter[9][@type='java.lang.String'] and parameter[10][@type='java.lang.String'] and parameter[11][@type='int']]"
		[Register(".ctor", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;IIIIIILjava/lang/String;Ljava/lang/String;I)V", "")]
		public unsafe SliderPage(global::Java.Lang.ICharSequence title, global::Java.Lang.ICharSequence description, int imageDrawable, int backgroundColor, int titleColor, int descriptionColor, int titleTypefaceFontRes, int descriptionTypefaceFontRes, string titleTypeface, string descriptionTypeface, int backgroundDrawable)
			: base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;IIIIIILjava/lang/String;Ljava/lang/String;I)V";

			if (((global::Java.Lang.Object)this).Handle != IntPtr.Zero)
				return;

			IntPtr native_title = CharSequence.ToLocalJniHandle(title);
			IntPtr native_description = CharSequence.ToLocalJniHandle(description);
			IntPtr native_titleTypeface = JNIEnv.NewString(titleTypeface);
			IntPtr native_descriptionTypeface = JNIEnv.NewString(descriptionTypeface);
			try
			{
				JniArgumentValue* __args = stackalloc JniArgumentValue[11];
				__args[0] = new JniArgumentValue(native_title);
				__args[1] = new JniArgumentValue(native_description);
				__args[2] = new JniArgumentValue(imageDrawable);
				__args[3] = new JniArgumentValue(backgroundColor);
				__args[4] = new JniArgumentValue(titleColor);
				__args[5] = new JniArgumentValue(descriptionColor);
				__args[6] = new JniArgumentValue(titleTypefaceFontRes);
				__args[7] = new JniArgumentValue(descriptionTypefaceFontRes);
				__args[8] = new JniArgumentValue(native_titleTypeface);
				__args[9] = new JniArgumentValue(native_descriptionTypeface);
				__args[10] = new JniArgumentValue(backgroundDrawable);
				var __r = _members.InstanceMethods.StartCreateInstance(__id, ((object)this).GetType(), __args);
				SetHandle(__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance(__id, this, __args);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(native_title);
				JNIEnv.DeleteLocalRef(native_description);
				JNIEnv.DeleteLocalRef(native_titleTypeface);
				JNIEnv.DeleteLocalRef(native_descriptionTypeface);
			}
		}

		[Register(".ctor", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;IIIIIILjava/lang/String;Ljava/lang/String;I)V", "")]
		public unsafe SliderPage(string title = null, string description = null, int imageDrawable = 0, int backgroundColor = 0, int titleColor = 0, int descriptionColor = 0, int titleTypefaceFontRes = 0, int descriptionTypefaceFontRes = 0, string titleTypeface = null, string descriptionTypeface = null, int backgroundDrawable = 0)
			: base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;IIIIIILjava/lang/String;Ljava/lang/String;I)V";

			if (((global::Java.Lang.Object)this).Handle != IntPtr.Zero)
				return;

			IntPtr native_title = CharSequence.ToLocalJniHandle(title);
			IntPtr native_description = CharSequence.ToLocalJniHandle(description);
			IntPtr native_titleTypeface = JNIEnv.NewString(titleTypeface);
			IntPtr native_descriptionTypeface = JNIEnv.NewString(descriptionTypeface);
			try
			{
				JniArgumentValue* __args = stackalloc JniArgumentValue[11];
				__args[0] = new JniArgumentValue(native_title);
				__args[1] = new JniArgumentValue(native_description);
				__args[2] = new JniArgumentValue(imageDrawable);
				__args[3] = new JniArgumentValue(backgroundColor);
				__args[4] = new JniArgumentValue(titleColor);
				__args[5] = new JniArgumentValue(descriptionColor);
				__args[6] = new JniArgumentValue(titleTypefaceFontRes);
				__args[7] = new JniArgumentValue(descriptionTypefaceFontRes);
				__args[8] = new JniArgumentValue(native_titleTypeface);
				__args[9] = new JniArgumentValue(native_descriptionTypeface);
				__args[10] = new JniArgumentValue(backgroundDrawable);
				var __r = _members.InstanceMethods.StartCreateInstance(__id, ((object)this).GetType(), __args);
				SetHandle(__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance(__id, this, __args);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(native_title);
				JNIEnv.DeleteLocalRef(native_description);
				JNIEnv.DeleteLocalRef(native_titleTypeface);
				JNIEnv.DeleteLocalRef(native_descriptionTypeface);
			}
		}
	}
}
